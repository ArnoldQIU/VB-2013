Module Module1
    Sub main()
        Dim i, num, sum As Integer
        Console.Write("請輸入總人數")
        num = Val(Console.ReadLine())
        Dim tall(num - 1) As Integer
        For i = 0 To tall.GetUpperBound(0)
            Console.Write("請輸入第{0}位身高:", i + 1.ToString())
            tall(i) = Val(Console.ReadLine())
        Next
        For Each height As Integer In tall
            sum += height
        Next
        Console.WriteLine("平均身高:{0}", CInt((sum / num)).ToString())
        Console.Read()
    End Sub
End Module
