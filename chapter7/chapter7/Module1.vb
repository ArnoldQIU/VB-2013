'Module Module1
'    Class employee
'        Private _salary As Integer
'        Public Property Salary() As Integer '建立屬性
'            Get
'                Return _salary
'            End Get
'            Set(ByVal value As Integer)
'                If value < 20000 Then
'                    _salary = 20000
'                ElseIf (value > 40000) Then
'                    _salary = 40000
'                Else
'                    _salary = value
'                End If
'            End Set
'        End Property
'    End Class
'    Class Manager
'        Inherits employee
'        Public Property Bouns As Integer
'        Public Sub showtotal()
'            Console.WriteLine("實領薪水:{0}", (Bouns + Salary).ToString())
'        End Sub
'    End Class
'    Sub Main()
'        Dim tom As New employee()
'        tom.Salary = 50000
'        Console.WriteLine("tom員工薪水{0}", tom.Salary.ToString())
'        Console.WriteLine("=========================")
'        Console.WriteLine()
'        Dim peter As New Manager()
'        peter.Salary = 50000
'        Console.WriteLine("peter經理薪水{0}", peter.Salary.ToString())
'        peter.Bouns = 30000
'        Console.WriteLine("peter經理獎金{0}", peter.Bouns.ToString())
'        peter.ShowTotal()
'        Console.Read()
'    End Sub

'End Module

'Module module1
'    Public Class car
'        Public Property No As Integer
'        Public Shared Property Total As Integer  'Total共用屬性計算車子總量
'        Public Shared Sub ShowTotalCars()
'            Console.WriteLine("現在共有{0}部車子", Total.ToString())
'        End Sub
'        Public Sub ShowMe(ByVal vCarName As String)
'            Console.WriteLine("{0}是第{1}部車", vCarName, No.ToString())
'        End Sub
'        Public Sub New() 'Car類別建構式
'            Total += 1
'            No = Total
'        End Sub
'        Protected Overrides Sub finalize()
'            Total -= 1

'        End Sub

'    End Class

'    Sub main()
'        car.ShowTotalCars()
'        Dim benz As New car()
'        Console.WriteLine("benz是第{0}台車", benz.No.ToString())
'        car.ShowTotalCars()
'        Dim bmw As New car()
'        bmw.ShowMe("BMW")
'        Dim ford As New car()
'        ford.ShowMe("ford")
'        car.ShowTotalCars()
'        Dim mycar As car 'car 的參考
'        car.ShowTotalCars()
'        mycar = bmw
'        mycar.ShowMe("MyCar")
'        Console.Read()


'    End Sub

'End Module

'Module module1
'    Class employee
'        Protected _salary As Integer
'        Public Overridable Property Salary() As Integer
'            Get
'                Return _salary
'            End Get
'            Set(ByVal value As Integer)
'                If value >= 20000 And value <= 40000 Then
'                    _salary = value
'                Else
'                    _salary = 20000

'                End If

'            End Set
'        End Property
'    End Class

'    Class Manager
'        Inherits employee
'        Public Property Bouns As Integer
'        Public Overrides Property Salary() As Integer
'            Get
'                Return _salary
'            End Get
'            Set(ByVal value As Integer)
'                If value >= 30000 And value <= 60000 Then
'                    _salary = value
'                Else
'                    _salary = 30000
'                End If
'            End Set
'        End Property
'        Public Sub showtotal()
'            Console.WriteLine("實領薪水:{0}", (Bouns + Salary).ToString())
'        End Sub
'    End Class

'    Sub main()
'        Dim peter As New Manager()
'        peter.Salary = 70000
'        peter.Bouns = 40000
'        Console.WriteLine("peter薪水：{0}", peter.Salary.ToString())

'        Console.WriteLine("peter獎金：{0}", peter.Bouns.ToString())
'        peter.showtotal()
'        Console.Read()
'    End Sub

'End Module

Module module1
    Class Traffic
        Protected Shared _miles As Integer
        Public Overridable Sub speedup()

        End Sub

    End Class
    Class car
        Inherits Traffic
        Public Overrides Sub speedup()
            _miles += 2
            Console.WriteLine("駕駛車子,加速中,前進{0}公里", _miles.ToString())
        End Sub
    End Class
    Class airplane
        Inherits Traffic
        Public Overrides Sub speedup()
            _miles += 15
            Console.WriteLine("駕駛飛機,加速中,前進{0}公里", _miles.ToString())
        End Sub
    End Class
    Sub main()
        Dim r As Traffic
        Dim mycar As New car()
        Dim myairplane As New airplane()
        Dim input As String
        Do While True
            Console.WriteLine("請問要駕駛->1.車子 2.飛機 其他.離開")
            input = Console.ReadLine()
            If input = "1" Then
                r = mycar
            ElseIf input = "2" Then
                r = myairplane
            Else
                Exit Do
            End If
            r.speedup()
            Console.WriteLine()

        Loop
        Console.ReadLine()
    End Sub

End Module