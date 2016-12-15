Public Class Form1
    Dim account As String = "Arnold"
    Dim password As String = "1234"
    Dim url As String = "www.google.com"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = account Then
            If TextBox2.Text = password Then
                System.Diagnostics.Process.Start(url)
            Else
                MessageBox.Show("帳號密碼錯誤")
            End If
        Else
            MessageBox.Show("帳號密碼錯誤")
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub
End Class
