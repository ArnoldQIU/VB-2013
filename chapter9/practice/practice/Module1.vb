'Module Module1

'    Sub Main()
'        Dim a, b, c As Integer
'        Console.WriteLine("a = ")
'        a = Console.ReadLine()
'        Console.WriteLine("b = ")
'        b = Console.ReadLine()
'        Try
'            c = a \ b
'        Catch ex As Exception
'            Console.WriteLine("fuck you")
'        End Try
'        Console.WriteLine("a\b={0}", c)
'        Console.ReadLine()
'    End Sub

'End Module


'Module module1
'    Sub main()
'        Dim i As Integer
'        Dim score() As Integer = {1, 2, 3}
'        For i = 0 To 3
'            Console.WriteLine("score({0}) =", i.ToString())
'            Try
'                Console.WriteLine(score(i).ToString())

'            Catch ex As IndexOutOfRangeException
'                Console.WriteLine()
'                Console.WriteLine("例外處理類型 :{0}", ex.GetType().ToString())
'                Console.WriteLine("錯誤訊息  :{0}", ex.Message)
'                Console.WriteLine("程式或物件名稱  :{0}", ex.Source)
'                Console.WriteLine("產生錯誤程序  :{0}", ex.TargetSite.Name.ToString())
'                Console.WriteLine("錯誤之處  :{0}", ex.StackTrace)
'            Finally
'                Console.WriteLine("index={0}", i.ToString())
'            End Try
'        Next
'        Console.ReadLine()
'    End Sub
'End Module

Module module1
    Class salaryexception
        Inherits Exception
        Public Overrides Function ToString() As String
            Return "發生Salary例外類別"
        End Function
        Public Overrides ReadOnly Property message() As String
            Get
                Return "薪水不為負或零"
            End Get
        End Property
        Public Sub showMsg()
            Console.WriteLine("薪水錯誤")
        End Sub

    End Class

    Class employee
        Private _name As String
        Private _salary As Integer
        Public Sub New(ByVal name As String)
            _name = name
        End Sub
        Public Property Salary() As Integer
            Get
                Return _salary
            End Get
            Set(ByVal value As Integer)
                If value < 0 Then
                    Console.WriteLine("設定{0}薪水失敗", _name)
                    Throw New salaryexception()
                Else
                    _salary = value
                End If
            End Set
        End Property
        Public Sub showsalary()
            Console.WriteLine("員工{0}的薪水{1}", _name, Salary.ToString())
        End Sub
    End Class

    Sub main()
        Try
            Dim tom As New employee("Tom")
            tom.Salary = 50000
            tom.showsalary()
            Console.WriteLine("============================")
            Dim arnold As New employee("Arnold")
            arnold.Salary = -1000
            arnold.showsalary()

        Catch ex As salaryexception
            Console.WriteLine(ex.ToString)
            Console.WriteLine(ex.message)
            ex.showMsg()

        End Try
        Console.ReadLine()
    End Sub

End Module