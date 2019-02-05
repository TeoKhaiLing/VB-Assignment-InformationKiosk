Public Class frmKiosk
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        wbWebBrowser.Navigate("http://www.wou.edu.my/school-of-science-and-technology/")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, PictureBox1.Click
        wbWebBrowser.Navigate("http://www.wou.edu.my/")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        wbWebBrowser.Navigate("http://www.wou.edu.my/school-of-business-administration/")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        wbWebBrowser.Navigate("http://www.wou.edu.my/school-of-english-and-communications/")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        wbWebBrowser.Navigate("http://www.wou.edu.my/school-of-humanities-social-sciences/")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        wbWebBrowser.Navigate("http://www.wou.edu.my/centre-for-graduate-studies/")
    End Sub
End Class
