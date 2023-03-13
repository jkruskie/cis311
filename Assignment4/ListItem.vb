Public Class ListItem
    ' Name
    Public Property Name As String
    ' Value
    Public Property Value As String

    ' To String
    Public Overrides Function ToString() As String
        Return Value & " - " & Name
    End Function
End Class
