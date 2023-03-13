Public Class LibraryManagerHome
    '------------------------------------------------------------
    '-                File Name : LibraryManagerHome.vb         - 
    '-                Part of Project: LibraryManagerHome       -
    '------------------------------------------------------------
    '-                Written By: Justin T. Kruskie             -
    '-                Written On: February 02, 2023             -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file contains the main form for the Library Manager -
    '- Home application. This form will allow the user to       -
    '- select add new libraries, media, and books.
    '------------------------------------------------------------
    '- Program Purpose:                                         -
    '-                                                          -
    '- The purpose of this program is to allow a user to        -
    '- manage a library. The user will be able to add new       -
    '- libraries, media, and books. The user will also be able  -
    '- to check out media and books from the library.           -
    '------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):             -
    '- lstLibraries - List of libraries                         -
    '- lstBooks - List of books                                 -
    '- lstMedia - List of media                                 -
    '------------------------------------------------------------


    '---------------------------------------------------------------------------------------
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '---------------------------------------------------------------------------------------
    ' Global list of libraries
    Public Shared lstLibraries As New List(Of Library)
    ' Global list of books
    Public Shared lstBooks As New List(Of Book)
    ' Global list of media
    Public Shared lstMedia As New List(Of Media)

    '-----------------------------------------------------------------------------------
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram will load the form. It will load the     -
        '- libraries, books, and media from the 'database'.         -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram           -
        '- e - The event arguments                                  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' I created initialize functions to load dummy data
        ' this can be commented out to just run without data
        ' Run the initialize function from Library.vb to load dummy data
        lstLibraries = Library.Initialize()
        ' Run the initialize function on the books to load dummy data
        lstBooks = Book.Initialize()
        ' Run the initialize function on the media to load dummy data
        lstMedia = Media.Initialize()

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
        '- This subprogram will display the libraries in the list   -
        '- box.                                                     -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- library - The current library being displayed            -
        '- item - The listitem being added to the listbox           -
        '------------------------------------------------------------

        ' Clear the listbox
        lstbLibraries.Items.Clear()
        ' Loop through the list of libraries
        ' and display them in alphabetical order
        For Each library As Library In lstLibraries.OrderBy(Function(l) l.Name)
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
        '- This subprogram will display the books in the list box.  -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- book - The current book being displayed                  -
        '- item - The listitem being added to the listbox           -
        '------------------------------------------------------------

        ' Clear the listbox
        lstbBooks.Items.Clear()
        ' Loop through the list of books
        ' and display them in order of key
        For Each book As Book In lstBooks.OrderBy(Function(b) b.Key)
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
        '- This subprogram will display the media in the list box.  -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- item - The listitem being added to the listbox           -
        '- media - The current media being displayed                -
        '------------------------------------------------------------

        ' Clear the listbox
        lstbMedia.Items.Clear()
        ' Loop through the list of media
        ' and display them in order of key
        For Each media As Media In lstMedia.OrderBy(Function(m) m.Key)
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

    Private Sub btnAddLibrary_Click(sender As Object, e As EventArgs) Handles btnAddLibrary.Click
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram will show the add library form.          -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram           -
        '- e - The event arguments                                  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- addLibrary - The add library form                        -
        '------------------------------------------------------------

        ' Show the add library form
        Dim addLibrary As New AddNewLibrary
        ' Show the form as a dialog
        addLibrary.ShowDialog()
        ' Check the dialog result
        If addLibrary.DialogResult = DialogResult.OK Then
            ' Add the new library to the list of libraries
            lstLibraries.Add(addLibrary.newLibrary)
            ' Display the libraries
            DisplayLibraries()
        End If
    End Sub

    Private Sub btnDeleteLibrary_Click(sender As Object, e As EventArgs) Handles btnDeleteLibrary.Click
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram will delete the selected libraries.      -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram           -
        '- e - The event arguments                                  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- library - The library being deleted                      -
        '- item - The listitem being deleted                        -
        '------------------------------------------------------------


        ' If nothing is selected from the listbox
        If lstbLibraries.SelectedIndex = -1 Then
            ' Set the error provider
            Me.errorDeleteLibrary.SetError(lstbLibraries, "Please select a library to delete")
            Return
        End If

        ' Clear the error provider
        Me.errorDeleteLibrary.Clear()

        ' Loop through all the selected items
        For Each item As ListItem In lstbLibraries.SelectedItems
            ' Find the library in the list of libraries
            Dim library As Library = lstLibraries.Find(Function(l) l.Key = item.Value)
            ' Remove the library from the list of libraries
            lstLibraries.Remove(library)
        Next

        ' Display the libraries
        DisplayLibraries()
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram will show the add book form.             -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram           -
        '- e - The event arguments                                  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- addBook - The add book form                              -
        '------------------------------------------------------------

        ' Show the add book form
        Dim addBook As New AddNewBook
        ' Show the form as a dialog
        addBook.ShowDialog()
        ' Check the dialog result
        If addBook.DialogResult = DialogResult.OK Then
            ' Add the new book to the list of books
            lstBooks.Add(addBook.newBook)
            ' Display the books
            DisplayBooks()
        End If
    End Sub

    Private Sub btnDeleteBook_Click(sender As Object, e As EventArgs) Handles btnDeleteBook.Click
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram will delete the selected books.          -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram           -
        '- e - The event arguments                                  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- book - The book being deleted                            -
        '- item - The listitem being deleted                        -
        '------------------------------------------------------------

        ' If nothing is selected from the listbox
        If lstbBooks.SelectedIndex = -1 Then
            ' Set the error provider
            Me.errorDeleteBook.SetError(lstbBooks, "Please select a book to delete")
            Return
        End If


        ' Clear the error provider
        Me.errorDeleteBook.Clear()

        ' Loop through all the selected items
        For Each item As ListItem In lstbBooks.SelectedItems
            ' Find the book in the list of books
            Dim book As Book = lstBooks.Find(Function(b) b.Key = item.Value)
            ' Remove the book from the list of books
            lstBooks.Remove(book)
        Next

        ' Display the books
        DisplayBooks()
    End Sub

    Private Sub btnAddMedia_Click(sender As Object, e As EventArgs) Handles btnAddMedia.Click
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram will show the add media form.            -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram           -
        '- e - The event arguments                                  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- addMedia - The add media form                            -
        '------------------------------------------------------------

        ' Show the add media form
        Dim addMedia As New AddNewMedia
        ' Show the form as a dialog
        addMedia.ShowDialog()
        ' Check the dialog result
        If addMedia.DialogResult = DialogResult.OK Then
            ' Add the new media to the list of media
            lstMedia.Add(addMedia.newMedia)
            ' Display the media
            DisplayMedia()
        End If
    End Sub

    Private Sub btnDeleteMedia_Click(sender As Object, e As EventArgs) Handles btnDeleteMedia.Click
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram will delete the selected media.          -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram           -
        '- e - The event arguments                                  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- item - The listitem being deleted                        -
        '- media - The media being deleted                          -
        '------------------------------------------------------------

        ' If nothing is selected from the listbox
        If lstbMedia.SelectedIndex = -1 Then
            ' Set the error provider
            Me.errorDeleteMedia.SetError(lstbMedia, "Please select a media to delete")
            Return
        End If

        ' Clear the error provider
        Me.errorDeleteMedia.Clear()

        ' Loop through all the selected items
        For Each item As ListItem In lstbMedia.SelectedItems
            ' Find the media in the list of media
            Dim media As Media = lstMedia.Find(Function(m) m.Key = item.Value)
            ' Remove the media from the list of media
            lstMedia.Remove(media)
        Next

        ' Display the media
        DisplayMedia()
    End Sub

    Private Sub btnLibraryScreen_Click(sender As Object, e As EventArgs) Handles btnLibraryScreen.Click
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram will show the library screen.            -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram           -
        '- e - The event arguments                                  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- libraryScreen - The library screen form                  -
        '------------------------------------------------------------

        Dim libraryCheckout As New LibraryCheckout
        ' Show the form as a dialog
        libraryCheckout.Show()

        ' Hide the current form
        Me.Hide()
    End Sub
End Class
