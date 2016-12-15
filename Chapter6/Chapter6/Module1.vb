Module Module1
    Class Emplyee
        Private _salary As Integer
        Private EName As String
        Public Event ShowError()
        Public Property Salary() As Integer
            Get
                Return _salary
            End Get
            Set(ByVal value As Integer)
                If (value < 20000 Or value > 40000) Then
                    RaiseEvent ShowError()
                End If
                _salary = value
            End Set
        End Property
        Public Sub PrintData(ByVal _name As String, ByVal _salary As Integer)
            Console.WriteLine("員工姓名:{0}", _name)
            Console.WriteLine("薪水:{0}", _salary.ToString)
        End Sub
    End Class
    Dim WithEvents emp As Emplyee
    Public Sub salaryerror() Handles emp.ShowError
        Console.WriteLine("薪水不正確")
    End Sub

    Sub main()

        Dim Ename As String
        Dim salary As Integer
        emp = New Emplyee()
        Console.Write("請輸入員工名稱")
        Ename = Console.ReadLine()
        Console.Write("請輸入員工薪水")
        salary = Console.ReadLine()
        emp.Salary = salary
        If emp.Salary <= 40000 And emp.Salary >= 20000 Then
            Console.WriteLine("--------員工資訊如下-----------")
            emp.PrintData(Ename, salary)
        End If
        Console.Read()
    End Sub
End Module

'Module module1
'    Class MyFirstClass

'    End Class
'    Sub main()
'        Console.WriteLine("建立myfirstclass物件")
'        Dim a As New MyFirstClass() '使用new建立類別

'        Console.WriteLine("A物件建立完成")
'            Console.WriteLine("請按enter結束")
'            Console.Read()

'    End Sub
'End Module

'Module module1
'    Class car
'        Private speed As Integer
'        Public Function GetSpeed() As Integer
'            Return speed
'        End Function

'        Public Sub setspeed(ByVal vspeed As Integer)
'            If vspeed < 0 Then vspeed = 0
'            If vspeed > 200 Then vspeed = 200
'            speed = vspeed
'        End Sub
'    End Class
'    Sub main()
'        Dim benz As New car()
'        benz.setspeed(500)
'        Console.WriteLine(benz.GetSpeed())
'        Console.Read()
'    End Sub
'End Module
