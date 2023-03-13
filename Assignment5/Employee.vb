Public Class Employee
    Public strFirstName As String
    Public strLastName As String
    Public intID As Integer
    Public sngMonSales As Single
    Public sngTueSales As Single
    Public sngWedSales As Single
    Public sngThuSales As Single
    Public sngFriSales As Single
    Public sngTotalSales As Single

    ' Constructor
    Public Sub New(ByVal lineParts As String())
        strFirstName = lineParts(0)
        strLastName = lineParts(1)
        intID = lineParts(2)
        sngMonSales = lineParts(3)
        sngTueSales = lineParts(4)
        sngWedSales = lineParts(5)
        sngThuSales = lineParts(6)
        sngFriSales = lineParts(7)
        ' Sum of all days
        sngTotalSales = sumSales(lineParts)
    End Sub

    Private Function sumSales(ByVal lineParts As String()) As Single
        Dim sum As Single = 0
        For i As Integer = 3 To 7
            sum += lineParts(i)
        Next
        Return sum
    End Function

End Class
