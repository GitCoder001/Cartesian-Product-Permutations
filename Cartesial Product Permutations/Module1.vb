Module Module1

    ' Find all unique combinations of a given set of values
    Dim combinations As New List(Of String)
    Sub Main()
        Permutation({1, 2, 3, 4})
        ' output combinations
        For Each s As String In combinations
            Console.WriteLine(s)
        Next
        Console.ReadLine()
    End Sub
    Sub Permutation(nums() As Integer, Optional start As Integer = 0)
        If start = nums.Length Then
            AddCombination(nums) ' base case
        Else
            For i As Integer = start To nums.Length - 1
                Swap(nums, start, i)
                Permutation(nums, start + 1) ' recursive call
                Swap(nums, start, i)
            Next
        End If

    End Sub
    Sub Swap(ByRef nums() As Integer, i As Integer, j As Integer)
        Dim temp As Integer
        temp = nums(i)
        nums(i) = nums(j)
        nums(j) = temp
    End Sub
    Sub AddCombination(nums() As Integer)
        Dim sString As String = ""

        For Each num As Integer In nums
            sString &= num.ToString
        Next

        If Not (combinations.Contains(sString)) Then
            combinations.Add(sString)
        End If

    End Sub
End Module
