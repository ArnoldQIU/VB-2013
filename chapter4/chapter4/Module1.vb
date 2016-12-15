'Module Module1

'    Sub Main()
'        Dim RoleName() As String = {"魯夫", "喬巴", "羅賓", "香吉士", "騙人布"}
'        Dim Money() As Integer = {300000000, 50, 78000000, 77000000, 300000000}
'        For i As Integer = 0 To RoleName.GetUpperBound(0) 'Getupperbound 取得陣列維度上限
'            Console.WriteLine("{0} {1} {2}",
'            RoleName(i), vbTab, Money(i).ToString())
'        Next
'        Console.Read()
'    End Sub

'End Module
Module module1
    Const pi As Double = 3.14159265
    Sub main()
        Dim intArray() As Integer = {2, 4, 6, 8}
        Dim action As New Action(Of Integer)(AddressOf ShowArea)
        Array.ForEach(intArray, action)
        Console.Read()

    End Sub
    Sub ShowArea(r As Integer)
        Console.WriteLine(vbNewLine & "半徑:{0:d}的圓面積為{1:f}", r, pi * r * r)
    End Sub
End Module
