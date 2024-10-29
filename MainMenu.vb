Public Class MainMenu
    Private Sub Student_Click(sender As Object, e As EventArgs) Handles Student.Click
        Dim mainmenu1 As New MainMenu
        Students.Show()
        Me.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim mainmenu1 As New MainMenu
        Books.Show()
        Me.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim mainmenu1 As New MainMenu
        Issue.Show()
        Me.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim mainmenu1 As New MainMenu
        ReturnBook.Show()
        Me.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim keluar As New MainMenu
        Form1.Show()
        Me.Show()
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim mainmenu1 As New MainMenu
        Borrow.Show()
        Me.Show()
        Me.Close()
    End Sub
End Class