Public Class Main_frm
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        keluar()
    End Sub

    Sub keluar()
        Login_frm.Show()
        Me.Close()
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        user_frm.MdiParent = Me
        user_frm.Show()
        user_frm.Top = 0
        user_frm.Left = 0
    End Sub

    Private Sub Main_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If idUser = 1 Then
            AdminToolStripMenuItem.Visible = True
        Else
            AdminToolStripMenuItem.Visible = False
        End If
    End Sub
End Class