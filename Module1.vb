'Module Module1

'    Sub Main()
'        Dim n1, n2 As Integer
'        Dim op As Char
'        Console.Write("輸入第一個數")
'        n1 = Console.ReadLine()
'        Console.Write("第二個數")
'        n2 = Console.ReadLine()
'        Console.Write("輸入運算符號")
'        op = Console.ReadLine()
'        Dim ans As Double
'        If op = "+" Then
'            ans = n1 + n2
'        ElseIf op = "-" Then
'            ans = n1 - n2
'        ElseIf op = "*" Then
'            ans = n1 * n2
'        ElseIf op = "/" Then
'            ans = n1 / n2
'        Else
'            Console.Write("輸錯了")
'        End If
'        Console.Write(ans)
'        Console.Read()



'End Sub

'End Module
'Module Module1
'    Sub Main()
'        Dim credit As Integer
'        Dim bank As String
'        Console.Write("輸入信用卡號")
'        credit = Console.ReadLine()
'        Select Case credit
'            Case 03
'                bank = "聯合信用卡"
'            Case 35
'                bank = "JCB"
'            Case 45, 46
'                bank = "VISA"
'            Case 54, 55
'                bank = "MASTER"
'            Case Else
'                bank = "非商業用信用卡"
'        End Select
'        Console.WriteLine(bank)
'        Console.ReadLine()
'    End Sub
'End Module
Module module1
    Sub main()
        Dim keyin, guess, count, min, max As Integer
        count = 0
        min = 0
        max = 1000
        Dim r As New Random()
        guess = r.Next(1, 100)
        Console.WriteLine("======猜數字遊戲=======")
        Console.WriteLine()
        Do
            Console.Write("猜數字範圍{0}<?<{1} :", min, max)
            keyin = Val(Console.ReadLine())
            count += 1
            If keyin >= 1 And keyin < 1000 Then
                If keyin = guess Then
                    Console.WriteLine("賓果 答案是{0}", guess)
                    Exit Do
                ElseIf keyin > guess Then
                    max = keyin
                    Console.Write("在小點")
                ElseIf keyin < guess Then
                    min = keyin
                    Console.Write("在大")
                End If
                Console.WriteLine("您猜了{0}次", count)
                Console.WriteLine()
            Else
                Console.WriteLine("請輸入提示範圍內")
            End If
        Loop While True
        Console.Read()
    End Sub

End Module