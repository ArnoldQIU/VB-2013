Public Class Form1
    Dim guess, count, min, max As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1_Load(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        count += 1
        Dim myguess As Integer = Val(TextBox1.Text)
        If myguess >= min And myguess < max Then
            If myguess = guess Then
                MessageBox.Show("賓果")
                Button1.Enabled = False
            ElseIf myguess > guess Then
                max = myguess
                MessageBox.Show("小一點")
            ElseIf myguess < guess Then
                min = myguess
                MessageBox.Show("大一點")

            End If
        Else
            MessageBox.Show("白癡 你輸錯了")
        End If
        Label7.Text = "共猜了" & count.ToString() & "次"
        Label1.Text = min.ToString() & "<?<" & max.ToString()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(500, 200)
        Dim r As New Random()
        guess = r.Next(1, 1000)
        min = 1
        max = 999
        count = 0
        Label1.Text = min.ToString() & "<?<" & max.ToString()
        Label7.Text = "共猜了" & count.ToString() & "次"
        Button1.Enabled = True
        TextBox1.Text = ""


    End Sub
End Class
