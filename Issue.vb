Public Class Issue
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim keluar3 As New Issue
        MainMenu.Show()
        Me.Show()
        Me.Close()
    End Sub

    Private Sub Issue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class