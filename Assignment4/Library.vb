Public Class Library
    ' Key
    Public Property Key As String
    ' Name
    Public Property Name As String
    ' Books
    Public Property Books As New List(Of Book)
    ' Media
    Public Property Media As New List(Of Media)

    Public Shared Function Initialize() As List(Of Library)
        '------------------------------------------------------------
        '-                Name: Justin T. Kruskie                   -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Function Purpose:                                        -
        '-                                                          -
        '- This function initializes the list of libraries.         -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- None                                                     -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- libraries - The list of libraries                        -
        '------------------------------------------------------------
        '- Returns:                                                 -
        '- List(Of Library) - The list of libraries                 -
        '------------------------------------------------------------

        ' New empty list of libraries
        ' Key: SVSU - Item: Zahnow Library
        ' Key: BR - Item: Fleschner Memorial Library
        ' Key: SDJ - Item: Scott D. James Technical Repository
        Dim libraries As New List(Of Library) From {
            New Library With {.Key = "SVSU", .Name = "Zahnow Library"},
            New Library With {.Key = "BR", .Name = "Fleschner Memorial Library"},
            New Library With {.Key = "SDJ", .Name = "Scott D. James Technical Repository"}
        }


        ' Add books to the library with key 'SVSU'
        ' and create new books
        ' Add the books to the library
        libraries.Where(Function(l) l.Key = "SVSU").FirstOrDefault().Books.AddRange({
            New Book With {.Key = "101", .Title = "Zen and the Art of Appliance Wiring"},
            New Book With {.Key = "104", .Title = "Data Structures for Fun And Profit"},
            New Book With {.Key = "105", .Title = "Programming with the Bidgoli"}
        })

        ' Add media to the library with key 'SVSU'
        ' and create new media
        ' Add the media to the library
        libraries.Where(Function(l) l.Key = "SVSU").FirstOrDefault().Media.Add(
            New Media With {.Key = "201", .Title = "CD - IEEE Computer: the Hits"}
        )

        ' Add books to the library with key 'SDJ'
        ' and create new books
        ' Add the books to the library
        libraries.Where(Function(l) l.Key = "SDJ").FirstOrDefault().Books.AddRange({
            New Book With {.Key = "102", .Title = "Interpretive Klingon Poetry"},
            New Book With {.Key = "105", .Title = "Programming with the Bidgoli"}
        })

        ' Add media to the library with key 'SDJ'
        ' and create new media
        ' Add the media to the library
        libraries.Where(Function(l) l.Key = "SDJ").FirstOrDefault().Media.AddRange({
            New Media With {.Key = "202", .Title = "DVD - The Pirates of Silicon Valley"}
        })

        Return libraries
    End Function

End Class
