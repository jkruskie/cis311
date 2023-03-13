Public Class AddNewMedia
    '------------------------------------------------------------
    '-                File Name : AddNewMedia.vb                -
    '-                Part of Project: AddNewMedia              -
    '------------------------------------------------------------
    '-                Written By: Justin T. Kruskie             -
    '-                Written On: February 02, 2023             -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file contains the code for the AddNewMedia form.    -
    '------------------------------------------------------------
    '- Program Purpose:                                         -
    '-                                                          -
    '- This program is a demonstration of how to add a new      -
    '- media to the library.                                    -
    '------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):             -
    '- newBook - The new book to add to the library             -
    '------------------------------------------------------------

    '---------------------------------------------------------------------------------------
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '---------------------------------------------------------------------------------------

    ' Global newLibrary
    Public Shared newMedia As New Media
    '-----------------------------------------------------------------------------------
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '------------------------------------------------------------
        '-                Name: Justin T. Kruskie                   -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram is called when the user clicks the save  -
        '- button. It checks the input and creates a new media.     -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram           -
        '- e - The event arguments                                  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- newMedia - The new media to add to the library           -
        '------------------------------------------------------------

        ' Check the identifier is not number
        If Not IsNumeric(txtIdentifier.Text) Then
            Me.ErrorProvider1.SetError(txtIdentifier, "Identifier must be a string")
            Return
        End If

        ' Check the identifier is not empty
        If txtIdentifier.Text = "" Then
            Me.ErrorProvider1.SetError(txtIdentifier, "Identifier cannot be empty")
            Return
        End If

        ' Check the identifier starts with 2
        If Not txtIdentifier.Text.StartsWith("2") Then
            Me.ErrorProvider1.SetError(txtIdentifier, "Identifier must start with 2")
            Return
        End If

        ' Check the name is not empty
        If txtName.Text = "" Then
            Me.ErrorProvider1.SetError(txtName, "Title cannot be empty")
            Return
        End If

        ' Check if the identifier is already in use
        If LibraryManagerHome.lstMedia.Exists(Function(b) b.Key = txtIdentifier.Text.ToUpper) Then
            Me.ErrorProvider1.SetError(txtIdentifier, "Identifier already in use")
            Return
        End If

        ' Check the address is not empty
        Me.ErrorProvider1.Clear()

        ' Create the new library
        newMedia = New Media With {
            .Key = txtIdentifier.Text.ToUpper,
            .Title = txtName.Text
        }

        ' Set the dialog result to OK
        Me.DialogResult = DialogResult.OK

        ' Close the form
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        '------------------------------------------------------------
        '-                Name: Justin T. Kruskie                   -
        '-                Written On: February 02, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram is called when the user clicks the       -
        '- cancel button. It closes the form.                       -
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
    End Sub
End Class