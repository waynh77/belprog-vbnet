Public Class brg_frm
    Dim nama As String

    Sub kosong()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        lblid.Text = ""
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
    End Sub

    Sub IsiGrid()
        sqLstr = "Select * from view_barang"
        tabel = proses.executequery(sqLstr)
        dgv1.DataSource = tabel
    End Sub

    Sub isiData2()
        Dim Idbrg As Integer = dgv1.Item("id", dgv1.CurrentRow.Index).Value
        sqLstr = "select * from msbrg where idbrg=" & Idbrg
        tabel = proses.executequery(sqLstr)
        Dim satuan As Integer = tabel.Rows(0).Item("satuan")
        With tabel
            lblid.Text = .Rows(0).Item("idbrg").ToString
            TextBox1.Text = .Rows(0).Item("namabrg").ToString
            TextBox2.Text = .Rows(0).Item("harga").ToString
            TextBox3.Text = .Rows(0).Item("qty").ToString
            ComboBox1.SelectedValue = .Rows(0).Item("jenisbrg").ToString
            ComboBox2.SelectedValue = satuan
        End With
    End Sub
    Sub IsiData()
        With dgv1
            If .Rows.Count > 0 And Button3.Visible = True Then
                lblid.Text = .Item("id", .CurrentRow.Index).Value
                TextBox1.Text = .Item("nama barang", .CurrentRow.Index).Value
                TextBox2.Text = .Item("harga", .CurrentRow.Index).Value
                TextBox3.Text = .Item("qty", .CurrentRow.Index).Value
                ComboBox1.SelectedValue = .Item("id jenis", .CurrentRow.Index).Value
                ComboBox2.SelectedValue = .Item("id satuan", .CurrentRow.Index).Value
            End If
        End With
    End Sub

    Sub btnAwal()
        Button1.Text = "Add"
        Button2.Text = "Edit"
        Button3.Text = "Delete"
        Button4.Text = "Keluar"
        Button3.Visible = True
        Button4.Visible = True
        TextBox1.Enabled = False
        dgv1.Enabled = True
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
    End Sub

    Sub BtnSimpan()
        Button1.Text = "Save"
        Button2.Text = "Cancel"
        Button3.Visible = False
        Button4.Visible = False
        TextBox1.Enabled = True
        dgv1.Enabled = False
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
    End Sub

    Sub IsiSatuan()
        ComboBox2.Items.Clear()
        sqLstr = "select * from tbsatuan"
        tabel = proses.executequery(sqLstr)
        ComboBox2.DataSource = tabel
        ComboBox2.DisplayMember = "satuan"
        ComboBox2.ValueMember = "idsatuan"
        'With tabel
        '    If .Rows.Count > 0 Then
        '        For i = 0 To .Rows.Count - 1
        '            ComboBox2.Items.Add(tabel.Rows(i).Item("satuan").ToString)
        '        Next
        '    End If
        '    ComboBox2.SelectedIndex = 0
        'End With
    End Sub

    Private Sub dgv1_Click(sender As Object, e As EventArgs) Handles dgv1.Click
        isiData2()
    End Sub

    'tombol tambah/simpan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Add" Then
            kosong()
            BtnSimpan()
            TextBox1.Focus()
        Else 'save
            If TextBox1.Text = "" Then
                MsgBox("Input masih Kosong")
            Else
                If lblid.Text = "" Then 'simpan tambah
                    'cek user name sudah ada atau tidak
                    sqLstr = "select * from msbrg where namabrg=" &
                        Aphostrophe(TextBox1.Text)
                    tabel = proses.executequery(sqLstr)
                    If tabel.Rows.Count > 0 Then
                        MsgBox("Barang sudah ada")
                    Else 'simpan tambah
                        sqLstr = "select top(1)* from msbrg" ' order by idbrg desc"
                        tabel = proses.executequery(sqLstr)
                        If tabel.Rows.Count > 0 Then
                            sqLstr = "declare @max int;
                    select @max=MAX(idbrg) from msbrg
                    DBCC CHECKIDENT(msbrg,reseed,@max) "
                        Else
                            sqLstr = "DBCC CHECKIDENT(msbrg,reseed,0) "
                        End If
                        sqLstr = sqLstr + "Insert into msbrg([jenisbrg]
      ,[namabrg]
      ,[satuan]
      ,[harga]
      ,[qty])values(" &
      ComboBox1.SelectedValue.ToString & "," &
                            Aphostrophe(TextBox1.Text) & "," &
                            ComboBox2.SelectedValue.ToString & "," &
                            Val(TextBox2.Text) & "," &
                            Val(TextBox3.Text) & ")"
                        proses.executenonquery(sqLstr)
                        MsgBox("Berhasil Tambah Data")
                        btnAwal()
                        IsiGrid()
                        isiData2()
                    End If
                Else 'update data
                    'cek user
                    sqLstr = "select * from msbrg where namabrg=" &
                        Aphostrophe(TextBox1.Text) & " and namabrg<>" &
                        Aphostrophe(nama)
                    tabel = proses.executequery(sqLstr)
                    If tabel.Rows.Count > 0 Then 'jika ada
                        MsgBox("Barang sudah ada")
                    Else 'update data
                        sqLstr = "update msbrg set namabrg=" &
                            Aphostrophe(TextBox1.Text) &
                        ",jenisbrg=" & ComboBox1.SelectedValue.ToString &
                        ", satuan=" & ComboBox2.SelectedValue.ToString &
                         ",harga=" & Val(TextBox2.Text) &
                         ", Qty=" & Val(TextBox3.Text) &
                        "where idbrg=" &
                            lblid.Text
                        proses.executenonquery(sqLstr)
                        MsgBox("Berhasil Update Data")
                        btnAwal()
                        IsiGrid()
                        isiData2()
                    End If
                End If

            End If
        End If
    End Sub

    'tombol edit cancel
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            If lblid.Text <> "" Then
                BtnSimpan()
                TextBox1.Focus()
                nama = TextBox1.Text
                If lblid.Text = 1 Then
                    TextBox1.Enabled = False
                End If
            End If

        Else 'cancel
            btnAwal()
        End If
    End Sub

    'hapus data
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If dgv1.Rows.Count > 0 Then
            Dim tny As String
            tny = MsgBox("apakah anda yakin", MsgBoxStyle.YesNo, "Hapus")
            If tny = vbYes Then
                sqLstr = "Delete from msbrg where idbrg=" & lblid.Text
                proses.executenonquery(sqLstr)
                MsgBox("Berhasil hapus")
                IsiGrid()
                IsiData()
            End If
        Else
            MsgBox("data kosong/belum dipilih")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub brg_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tbJenis' table. You can move, or remove it, as needed.
        Me.TbJenisTableAdapter.Fill(Me.DataSet1.tbJenis)
        btnAwal()
        IsiSatuan()
        IsiGrid()
        IsiData()
        'test
    End Sub
End Class