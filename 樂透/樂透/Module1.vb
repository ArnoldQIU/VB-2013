Imports System.IO
Module Module1
    Sub main()
        Dim sr As streamreader
        Dim sw As StreamWriter
        Dim f As New FileInfo("2.txt")
        Dim rnds(10)
        Dim num As Integer
        sw = f.CreateText()

        For i As Integer = 0 To 9
            num = CInt(Int((10 * Rnd()) + 101))
            Dim counter As Integer = 0
            Dim j As Integer = 0
            While (j < i)
                If (rnds(i) = rnds(j)) Then
                    rnds(i) = CInt(Int((10 * Rnd()) + 101))
                    j = 0

                End If
                j += 1
            End While

        Next

        For a As Integer = 0 To 9
            sw.Write(" ")
            sw.Write(rnds(a))

        Next
        sw.Flush()
        sw.Close()
    End Sub
End Module

