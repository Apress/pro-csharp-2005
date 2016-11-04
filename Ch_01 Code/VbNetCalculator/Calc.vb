' Calc.vb
Imports System

Namespace CalculatorExample
    Class Calc
        Public Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
            Return x + y
        End Function
    End Class

    ' A VB .NET 'Module' is a class that only contains
    ' static members.
    Module CalcApp
        Sub Main()
            Dim ans As Integer
            Dim c As New Calc
            ans = c.Add(10, 84)
            Console.WriteLine("10 + 84 is {0}.", ans)
            Console.ReadLine()
        End Sub
    End Module
End Namespace
