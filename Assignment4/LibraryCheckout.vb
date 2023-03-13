Public Class LibraryCheckout
    '------------------------------------------------------------
    '-                File Name : LibraryCheckout.vb            - 
    '-                Part of Project: LibraryCheckout          -
    '------------------------------------------------------------
    '-                Written By: Justin T. Kruskie             -
    '-                Written On: February 02, 2023             -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file contains the code for the LibraryCheckout      -
    '- form.                                                    -
    '------------------------------------------------------------
    '- Program Purpose:                                         -
    '-                                                          -
    '- This program is designed to allow the user to check out  -
    '- books and media from a library.                          -
    '------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):             -
    '- libraryKey - The Index key for the library               -
    '------------------------------------------------------------


    '---------------------------------------------------------------------------------------
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '---------------------------------------------------------------------------------------
    Public libraryKey As String

    '-----------------------------------------------------------------------------------
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------

    Private Sub LibraryCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram is called when the form is loaded. It    -
        '- displays the libraries, books, and media.                -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -   
        '- sender - The object that called the subprogram           -
        '- e - The event arguments                                  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' Display the libraries
        DisplayLibraries()
        ' Display the books
        DisplayBooks()
        ' Display the media
        DisplayMedia()
    End Sub

    Private Sub DisplayLibraries()
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram displays the libraries in the listbox.   -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- library - The library to display                         -
        '- item - The listitem to add to the listbox                -
        '------------------------------------------------------------

        ' Clear the listbox
        lstbLibraries.Items.Clear()
        ' Loop through the list of libraries
        ' and display them in alphabetical order
        For Each library As Library In LibraryManagerHome.lstLibraries.OrderBy(Function(l) l.Name)
            ' Create new listitem
            Dim item As New ListItem
            ' Set the text to the library name
            item.Name = library.Name
            ' Set the value to the library key
            item.Value = library.Key

            ' Add the item to the listbox
            lstbLibraries.Items.Add(item)
        Next
    End Sub

    Private Sub DisplayBooks()
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram displays the books in the listbox.       -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- book - The book to display                               -
        '- item - The listitem to add to the listbox                -
        '------------------------------------------------------------

        ' Clear the listbox
        lstbBooks.Items.Clear()
        ' Loop through the list of books
        ' and display them in order of key
        For Each book As Book In LibraryManagerHome.lstBooks.OrderBy(Function(b) b.Key)
            ' Create new listitem
            Dim item As New ListItem
            ' Set the text to the book title
            item.Name = book.Title
            ' Set the value to the book key
            item.Value = book.Key

            ' Add the item to the listbox
            lstbBooks.Items.Add(item)
        Next
    End Sub

    Private Sub DisplayMedia()
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram displays the media in the listbox.       -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- item - The listitem to add to the listbox                -
        '- media - The media to display                             -
        '------------------------------------------------------------

        ' Clear the listbox
        lstbMedia.Items.Clear()
        ' Loop through the list of media
        ' and display them in order of key
        For Each media As Media In LibraryManagerHome.lstMedia.OrderBy(Function(m) m.Key)
            ' Create new listitem
            Dim item As New ListItem
            ' Set the text to the media title
            item.Name = media.Title
            ' Set the value to the media key
            item.Value = media.Key

            ' Add the item to the listbox
            lstbMedia.Items.Add(item)
        Next
    End Sub

    Private Sub lstbLibraries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbLibraries.SelectedIndexChanged
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram is called when the selected index of     -
        '- the libraries listbox is changed. It displays the        -
        '- assigned books and media.                                -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram           -
        '- e - The event arguments                                  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' Clear the error provider
        Me.errorLibraries.Clear()

        ' Check if an item was actually selected and its not just an empty space
        If Not lstbLibraries.SelectedItem Is Nothing Then
            ' Set the library key
            libraryKey = CType(lstbLibraries.SelectedItem, ListItem).Value
            ' Display the assigned books
            DisplayAssignedBooks()

            ' Display the assigned media
            DisplayAssignedMedia()
        End If

    End Sub

    Private Sub DisplayAssignedMedia()
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram displays the assigned media in the       -
        '- listbox.                                                 -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- libraryKey - The key of the library to display           -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- item - The listitem to add to the listbox                -
        '- media - The media to display                             -
        '------------------------------------------------------------

        ' Clear the listbox
        lstbCurrentMedia.Items.Clear()
        ' Loop through the list of media
        ' and display them in order of key
        ' using the librarykey to get them 
        ' from the library
        For Each media As Media In LibraryManagerHome.lstLibraries.Find(Function(l) l.Key = libraryKey).Media.OrderBy(Function(m) m.Key)
            ' Create new listitem
            Dim item As New ListItem
            ' Set the text to the media title
            item.Name = media.Title
            ' Set the value to the media key
            item.Value = media.Key

            ' Add the item to the listbox
            lstbCurrentMedia.Items.Add(item)
        Next
    End Sub

    Private Sub DisplayAssignedBooks()
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram displays the assigned books in the       -
        '- listbox.                                                 -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- item - The listitem to add to the listbox                -
        '- book - The book to display                               -
        '------------------------------------------------------------

        ' Clear the listbox
        lstbCurrentBooks.Items.Clear()
        ' Loop through the list of books
        ' and display them in order of key
        ' using the librarykey to get them
        ' from the library
        For Each book As Book In LibraryManagerHome.lstLibraries.Find(Function(l) l.Key = libraryKey).Books.OrderBy(Function(b) b.Key)
            ' Create new listitem
            Dim item As New ListItem
            ' Set the text to the book title
            item.Name = book.Title
            ' Set the value to the book key
            item.Value = book.Key

            ' Add the item to the listbox
            lstbCurrentBooks.Items.Add(item)
        Next
    End Sub

    Private Sub btnBooksAssign_Click(sender As Object, e As EventArgs) Handles btnBooksAssign.Click
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram is called when the assign books button   -
        '- is clicked. It assigns the selected books to the         -
        '- selected library.                                        -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram           -
        '- e - The event arguments                                  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- book - The book to assign                                -
        '------------------------------------------------------------

        ' Check if the library key is empty
        If String.IsNullOrEmpty(libraryKey) Then
            ' Display error message
            Me.errorLibraries.SetError(lstbLibraries, "Please select a library")
            ' Exit the sub
            Exit Sub
        End If

        ' Loop through the selected books
        For Each book As ListItem In lstbBooks.SelectedItems
            ' Use the book.value to check if the book exists in the library
            ' If it doesn't exist, add it
            If LibraryManagerHome.lstLibraries.Find(Function(l) l.Key = libraryKey).Books.Find(Function(b) b.Key = book.Value) Is Nothing Then
                ' Add the book to the library
                LibraryManagerHome.lstLibraries.Find(Function(l) l.Key = libraryKey).Books.Add(LibraryManagerHome.lstBooks.Find(Function(b) b.Key = book.Value))
            End If
        Next

        ' Clear the selected items
        lstbBooks.ClearSelected()

        ' Display the assigned books
        DisplayAssignedBooks()
    End Sub

    Private Sub btnBooksUnassign_Click(sender As Object, e As EventArgs) Handles btnBooksUnassign.Click
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -   
        '-                                                          -
        '- This subprogram is called when the unassign books button -
        '- is clicked. It unassigns the selected books from the     -
        '- selected library.                                        -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram           -
        '- e - The event arguments                                  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- book - The book to unassign                              -
        '------------------------------------------------------------

        ' Check if the library key is empty
        If String.IsNullOrEmpty(libraryKey) Then
            ' Display error message
            Me.errorLibraries.SetError(lstbLibraries, "Please select a library")
            ' Exit the sub
            Exit Sub
        End If

        ' Loop through all the selected assigned books
        For Each book As ListItem In lstbCurrentBooks.SelectedItems
            ' Remove the book using the key from the listitem
            ' Delete the entire book from the library using the book.value
            LibraryManagerHome.lstLibraries.Find(Function(l) l.Key = libraryKey).Books.RemoveAll(Function(b) b.Key = book.Value)
        Next

        ' Clear the selected items
        lstbCurrentBooks.ClearSelected()

        ' Display the assigned books
        DisplayAssignedBooks()
    End Sub

    Private Sub btnAssignMedia_Click(sender As Object, e As EventArgs) Handles btnAssignMedia.Click
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram is called when the assign media button   -
        '- is clicked. It assigns the selected media to the         -
        '- selected library.                                        -   
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram           -
        '- e - The event arguments                                  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- media - The media to assign                              -
        '------------------------------------------------------------

        ' Check if the library key is empty
        If String.IsNullOrEmpty(libraryKey) Then
            ' Display error message
            Me.errorLibraries.SetError(lstbLibraries, "Please select a library")
            ' Exit the sub
            Exit Sub
        End If

        ' Loop through the selected media
        For Each media As ListItem In lstbMedia.SelectedItems
            ' Use the media.value to check if the media exists in the library
            ' If it doesn't exist, add it
            If LibraryManagerHome.lstLibraries.Find(Function(l) l.Key = libraryKey).Media.Find(Function(m) m.Key = media.Value) Is Nothing Then
                ' Add the media to the library
                LibraryManagerHome.lstLibraries.Find(Function(l) l.Key = libraryKey).Media.Add(LibraryManagerHome.lstMedia.Find(Function(m) m.Key = media.Value))
            End If
        Next

        ' Clear the selected items
        lstbMedia.ClearSelected()

        ' Display the assigned media
        DisplayAssignedMedia()
    End Sub

    Private Sub btnUnassignMedia_Click(sender As Object, e As EventArgs) Handles btnUnassignMedia.Click
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram is called when the unassign media button -
        '- is clicked. It unassigns the selected media from the     -
        '- selected library.                                        -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram           -
        '- e - The event arguments                                  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- media - The media to unassign                            -
        '------------------------------------------------------------

        ' Check if the library key is empty
        If String.IsNullOrEmpty(libraryKey) Then
            ' Display error message
            Me.errorLibraries.SetError(lstbLibraries, "Please select a library")
            ' Exit the sub
            Exit Sub
        End If

        ' Loop through all the selected assigned media
        For Each media As ListItem In lstbCurrentMedia.SelectedItems
            ' Remove the media using the key from the listitem
            ' Delete the entire media from the library using the media.value
            LibraryManagerHome.lstLibraries.Find(Function(l) l.Key = libraryKey).Media.RemoveAll(Function(m) m.Key = media.Value)
        Next

        ' Clear the selected items
        lstbCurrentMedia.ClearSelected()

        ' Display the assigned media
        DisplayAssignedMedia()
    End Sub

    Private Sub btnLibraryScreen_Click(sender As Object, e As EventArgs) Handles btnLibraryScreen.Click
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -   
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram is called when the library screen button -
        '- is clicked. It closes the form and shows the library     -
        '- screen.                                                  -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram           -
        '- e - The event arguments                                  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' Close the form
        Me.Close()

        ' Show the library screen
        LibraryManagerHome.Show()
    End Sub
End Class