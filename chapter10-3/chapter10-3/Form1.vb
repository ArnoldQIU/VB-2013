Public Class Form1
    Dim num As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num = TextBox1.Text
        Dim total As Double
        For n As Integer = 1 To num
            total += 1 / n

        Next
        MessageBox.Show(total)
    End Sub
End Class
