Public Class frmCal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myMoney, myYear, total As Integer
        Dim myRate As Single
        Try
            myMoney = Val(frmMain.TextBox1.Text)
            myYear = Val(frmMain.TextBox3.Text)
            myRate = CDbl(frmMain.TextBox2.Text) / 100
            If RadioButton1.Checked Then
                total = YCalTotal(myMoney, myYear, myRate)
                frmMain.Label4.Text = "***每年算一次," & myYear.ToString() & "年後領回本利和" & total.ToString()
            Else
                total = Mcaltotal(myMoney, myYear, myRate)
                frmMain.Label4.Text = "***每月算一次," & myYear.ToString() & "年後領回本利和" & total.ToString()
            End If
        Catch ex As Exception
            frmMain.Label4.Text = "請輸入正確資料"

        End Try
    End Sub
End Class