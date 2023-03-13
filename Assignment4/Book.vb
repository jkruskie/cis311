Public Class Book
    ' Key
    Public Property Key As Integer
    ' Title
    Public Property Title As String

    ' Initialize
    Public Shared Function Initialize() As List(Of Book)
        '------------------------------------------------------------
        '-                Name: Justin T. Kruskie                   -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Function Purpose:                                        -
        '-                                                          -
        '- This function initializes the list of books.             -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- None                                                     -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- books - The list of books                                -
        '------------------------------------------------------------
        '- Returns:                                                 -
        '- List(Of Book) - The list of books                        -
        '------------------------------------------------------------



        ' New empty list of books
        ' Key: 101 - Item: Zen And the Art of Appliance Wiring
        ' Key: 102 - Item: Interpretive Klingon Poetry
        ' Key: 103 - Item: Doing More With Less - Navel Lint Art
        ' Key: 104 - Item: Data Structures for Fun And Profit
        ' Key: 105 - Item: Programming with the Bidgoli
        Dim books As New List(Of Book) From {
            New Book With {.Key = 101, .Title = "Zen And the Art of Appliance Wiring"},
            New Book With {.Key = 102, .Title = "Interpretive Klingon Poetry"},
            New Book With {.Key = 103, .Title = "Doing More With Less - Navel Lint Art"},
            New Book With {.Key = 104, .Title = "Data Structures for Fun And Profit"},
            New Book With {.Key = 105, .Title = "Programming with the Bidgoli"}
        }

        ' Return the list of books
        Return books
    End Function
End Class
