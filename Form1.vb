Imports Perpustakaan_Fix.PerpustakaanDataSetTableAdapters


Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UserName.Text = "admin" And Password.Text = "admin" Then
            Dim mainmenu1 As New MainMenu
            mainmenu1.Show()
            Me.Show()
            Me.Close()
        Else
            MessageBox.Show("Silahkan Coba Lagi!", "Input Salah", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim formadmin As New Form1
        AdminAccess.Show()
        Me.Show()
        Me.Close()

    End Sub


End Class

