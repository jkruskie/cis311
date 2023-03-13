Public Class Media
    ' Key
    Public Property Key As Integer
    ' Title
    Public Property Title As String

    ' Initialize
    Public Shared Function Initialize() As List(Of Media)
        '------------------------------------------------------------
        '-                Name: Justin T. Kruskie                   -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Function Purpose:                                        -
        '-                                                          -
        '- This function initializes the list of media.             -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- None                                                     -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- media - The list of media                                -
        '------------------------------------------------------------
        '- Returns:                                                 -
        '- List(Of Media) - The list of media                       -
        '------------------------------------------------------------

        ' New empty list of media
        ' Key: 201 - Item: CD -IEEE Computer: the Hits
        ' Key: 202 - Item: DVD -The Pirates of Silicon Valley
        ' Key: 203 - Item: DVD -Databases And You: the Video Experience
        Dim media As New List(Of Media) From {
            New Media With {.Key = 201, .Title = "CD - IEEE Coputer: the Hits"},
            New Media With {.Key = 202, .Title = "DVD -The Pirates of Silicon Valley"},
            New Media With {.Key = 203, .Title = "DVD - Databases aAd You: the Video Experience"}
        }

        ' Return the list of media
        Return media
    End Function
End Class
