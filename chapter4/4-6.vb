Module Module1

    Sub Main()
        Dim RoleName() As String = {"魯夫", "喬巴", "羅賓", "香吉士", "騙人布"}
        Dim Money() As Integer = {300000000, 50, 78000000, 77000000, 300000000}
        For i As Integer = 0 To RoleName.GetUpperBound(0) 'Getupperbound 取得陣列維度上限
            Console.WriteLine("{0} {1} {2}",
            RoleName(i), vbTab, Money(i).ToString())
        Next
        Console.Read()
    End Sub

End Module