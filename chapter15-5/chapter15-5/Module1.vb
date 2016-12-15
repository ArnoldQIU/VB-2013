Module Module1
    Public Function YCalTotal(vMoney As Integer, vyear As Integer, vRate As Double) As Integer
        Return vMoney * Math.Pow(1 + vRate, vyear)
    End Function
    Public Function Mcaltotal(vMoney As Integer, vYear As Integer, vRate As Double) As Integer
        Return vMoney * Math.Pow(1 + (vRate) / 12, vYear * 12)

    End Function
End Module
