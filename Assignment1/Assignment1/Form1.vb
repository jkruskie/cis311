Imports System.IO

Public Class Form1
    '------------------------------------------------------------
    '-                File Name : Form1.vb                      - 
    '-                Part of Project: Assignment1              -
    '------------------------------------------------------------
    '-                Written By: Justin T. Kruskie             -
    '-                Written On: January 11, 2023              -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file contains the main form for the entire appli-   -
    '- cation.  All user input is gathered on this form.  The   -
    '- calculations which are performed by the application      -
    '- reside in this file as well.  Finally all generated      -
    '- output is contained here too.                            -
    '------------------------------------------------------------
    '- Program Purpose:                                         -
    '-                                                          -
    '- The purpose of this program is to handle the inventory   -
    '- of IT devices for a local IT company. The application    -
    '- on initalization will check for already existing data    -
    '- and load that if available. If not, the default user     -
    '- interface will load to allow the user to insert a new    -
    '- inventory item. If data exists, the application          -
    '- returns the main page which allows navigation between    -
    '- all the inventoried data.                                -
    '------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):             -
    '- aCompanyBill - A user defined structure which will hold  –
    '-                the company name along with all numeric   -
    '-                values for the project currently being    -
    '-                calculated.                               -
    '------------------------------------------------------------

    '---------------------------------------------------------------------------------------
    '--- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS ---
    '--- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS ---
    '--- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS ---
    '---------------------------------------------------------------------------------------
    Const gstrFILE_NAME As String = "Inventory.txt"         ' The name of the file to be used for data storage
    Const gintGB_BYTE_CONVERSION As Integer = 1073741824    ' Conversion between GB and Bytes

    '-------------------------------------------------------------------------------------------
    '--- GLOBAL STRUCTURES --- GLOBAL STRUCTURES --- GLOBAL STRUCTURES --- GLOBAL STRUCTURES ---
    '--- GLOBAL STRUCTURES --- GLOBAL STRUCTURES --- GLOBAL STRUCTURES --- GLOBAL STRUCTURES ---
    '--- GLOBAL STRUCTURES --- GLOBAL STRUCTURES --- GLOBAL STRUCTURES --- GLOBAL STRUCTURES ---
    '-------------------------------------------------------------------------------------------
    Structure udtInventoryItem              ' Structure to hold all the data for a single inventory item
        Dim strManufacturer As String       ' Manufacturer of the device
        Dim strForm As String               ' Form Factor of the device
        Dim strProcessor As String          ' Processor type for the device
        Dim sngMemoryGB As Single           ' Amount of memory in GB
        Dim dblMemoryBytes As Double        ' Amount of memory in bytes
        Dim strVideo As String              ' Video card type for the device
        Dim sngVideoMemoryGB As Single      ' Amount of video memory in GB
        Dim dblVideoMemoryBytes As Double   ' Amount of video memory in bytes
        Dim sngStorageGB As Single          ' Storage capacity in GB
        Dim dblStorageBytes As Double       ' Storage capacity in bytes
        Dim blnWireless As Boolean          ' Boolean whether device is wireless
    End Structure

    '---------------------------------------------------------------------------------------
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '---------------------------------------------------------------------------------------
    Dim aInventory As udtInventoryItem()            ' Array of inventory items
    Dim blnEmptyInventory As Boolean = True         ' Whether or not the inventory is empty or not
    Dim blnSaveMode As Boolean = False              ' Whether or not the application is in save mode
    Dim intCurrentItem As Integer = 0               ' The current item being viewed
    Dim blnDisplayBytes As Boolean = False          ' Whether or not the application is displaying bytes or GB

    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------

    Private Sub Form1_Load() Handles MyBase.Load
        '------------------------------------------------------------
        '-                Subprogram Name: Form1_Load               -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 11, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine will run on load of the form and check   -
        '- if the inventory file exists and if so, load the data     -
        '- into the array. If not, the file will be created.         -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- blnLoadStatus - This is a boolean value of the status    - 
        '-                 of the import of the data into memory.   -
        '------------------------------------------------------------

        'Check if the file exists
        If File.Exists(gstrFILE_NAME) Then
            ' Print a console message
            Console.WriteLine("File exists, loading data...")
            ' If so, load the data into the array
            Dim blnLoadStatus As Boolean = LoadInventory()

            ' Check if the load was successful
            If blnLoadStatus Then
                ' If so, print a console message
                Console.WriteLine("Data loaded successfully!")
            Else
                ' If not, print a console message
                Console.WriteLine("Data failed to load!")
                ' Display messagebox with error message
                MessageBox.Show("Error loading data from file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' Delete the inventory file to prevent further errors
                DeleteInventoryFile()
            End If
        Else
            ' Print a console message
            Console.WriteLine("File does not exist, creating file...")
            ' If not, create the file
            ' CreateInventoryFile()
        End If

        ' Console log inventory status
        Console.WriteLine("Inventory is empty: " & blnEmptyInventory)

        ' Now that the inventory is loaded
        ' we will hide or show the buttons based on inventory status
        ' if blnEmptyInventory is true enter saveMode
        If blnEmptyInventory = True Then
            ' Print a console message
            Console.WriteLine("Entering save mode...")
            blnSaveMode = True
            saveModeEnabled()
            ChangeFormTitle()
        Else
            ' Print a console message
            Console.WriteLine("Entering view mode...")
            blnSaveMode = False
            SaveModeDisabled()
            ChangeFormTitle()
        End If


    End Sub

    Private Function LoadInventory() As Boolean
        '------------------------------------------------------------
        '-                Subprogram  Name: LoadInventory           -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 11, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- Load the data from the file into the array               -
        '- the data is stored as a tab seperated list               -
        '- the first line is the header and is ignored              -
        '- the data is stored in the following order:               -
        '- Manufacturer, Form, Processor, MemoryGB, MemoryBytes,    -
        '- Video, VideoMemoryGB, VideoMemoryBytes,                  -
        '- StorageGB, StorageBytes, Wireless.                       -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- intArraySize - This is the number of lines               -
        '- intLineCounter - This is the line counter for the loop   -
        '- strData - This is the raw data from the file             -
        '- strLine - This is the split line during loop             -
        '------------------------------------------------------------
        '- Returns:                                                 -
        '- Boolean - This is a boolean value of the status of the   -
        '-           import of the data into memory.                -
        '------------------------------------------------------------

        ' Load the data from the file into the array
        Try
            ' Read the file into a string array
            Dim strData() As String = File.ReadAllLines(gstrFILE_NAME)

            ' Get the number of lines in the file
            Dim intArraySize As Integer = strData.Length - 1
            ' Resize the array to the size of the file
            ReDim aInventory(intArraySize)

            Console.WriteLine("Array size: " & intArraySize)

            ' If the file is not empty (has data)
            ' set blnEmptyInventory to false
            If intArraySize >= 0 Then
                blnEmptyInventory = False
            End If

            ' Add the data to the array
            For intLineCounter As Integer = 0 To intArraySize

                ' Split the line into an array
                Dim strLine() As String = strData(intLineCounter).Split(vbTab)

                Console.WriteLine("ITEM " & strLine(0) & " " & strLine(1) & " " & strLine(2) & " " & strLine(3) & " " & strLine(4) & " " & strLine(5) & " " & strLine(6) & " " & strLine(7) & " " & strLine(8) & " " & strLine(9))

                ' Add the data to the array
                aInventory(intLineCounter).strManufacturer = strLine(0)     ' Manufacturer
                aInventory(intLineCounter).strForm = strLine(1)             ' Form
                aInventory(intLineCounter).strProcessor = strLine(2)        ' Processor
                aInventory(intLineCounter).sngMemoryGB = strLine(3)         ' MemoryGB
                aInventory(intLineCounter).dblMemoryBytes = strLine(4)      ' MemoryBytes
                aInventory(intLineCounter).strVideo = strLine(5)            ' Video
                aInventory(intLineCounter).sngVideoMemoryGB = strLine(6)    ' VideoMemoryGB
                aInventory(intLineCounter).dblVideoMemoryBytes = strLine(7) ' VideoMemoryBytes
                aInventory(intLineCounter).sngStorageGB = strLine(8)        ' StorageGB
                aInventory(intLineCounter).dblStorageBytes = strLine(9)     ' StorageBytes
                aInventory(intLineCounter).blnWireless = strLine(10)        ' Wireless
                ' Print a console message
                Console.WriteLine("Loaded data for item #" & intLineCounter)
            Next
            ' Return true for successful load
            Return True
        Catch ex As Exception
            ' Return false for failed load
            Return False
        End Try
    End Function

    Private Sub DeleteInventoryFile()
        '------------------------------------------------------------
        '-                Subprogram  Name: DeleteInventoryFile     -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 11, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- Delete the inventory file                                -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' Delete the inventory file
        File.Delete(gstrFILE_NAME)
        ' Print a console message
        Console.WriteLine("Inventory file deleted!")
    End Sub

    Private Sub CreateInventoryFile()
        '------------------------------------------------------------
        '-                Subprogram  Name: CreateInventoryFile     -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 11, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- Create the inventory file and apply the headers          -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- strHeaders - This is the headers for the file            -
        '------------------------------------------------------------

        ' Create the inventory file
        ' Dim file As FileStream = file.Create("./PalletQueue/Printer1" & ".txt")





        ' Add headers to file
        ' Dim strHeaders As String = "Manufacturer" & vbTab & "Form" & vbTab & "Processor" & vbTab & "MemoryGB" & vbTab & "MemoryBytes" & vbTab & "Video" & vbTab & "VideoMemoryGB" & vbTab & "VideoMemoryBytes" & vbTab & "StorageGB" & vbTab & "StorageBytes" & vbTab & "Wireless"
        ' File.AppendAllText(gstrFILE_NAME, strHeaders & vbNewLine)

        ' Print a console message
        Console.WriteLine("Inventory file created!")
    End Sub

    Private Sub saveModeEnabled()
        '------------------------------------------------------------
        '-                Subprogram  Name: saveModeEnabled         -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 11, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- Hide the buttons that are not needed in save mode        -
        '- and renames the buttons to make sense in save mode       -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' Print a console message
        Console.WriteLine("Save mode enabled!")

        ' Set the text of the left button to Save 
        btnLeft.Text = "Save"

        ' Set the text of the right button to Cancel
        btnRight.Text = "Cancel"

        ' Hide the middle button
        btnMiddle.Visible = False

        ' Clear all the inputs
        ClearInputs()

        ' Enable all inputs
        EnableInputs()

        ' Set the user focus to the txtManufacturer
        txtManufacturer.Focus()

    End Sub

    Private Sub SaveModeDisabled()
        '------------------------------------------------------------
        '-                Subprogram  Name: SaveModeDisabled        -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 11, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- Show the buttons that are not needed in save mode        -
        '- and renames the buttons to make sense in save mode       -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -   
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------
        ' Print a console message
        Console.WriteLine("Save mode disabled!")

        ' Set the left button text to << Previous
        btnLeft.Text = "<< Previous"

        ' Set the right button text to Next >>
        btnRight.Text = "Next >>"

        ' Set the middle button text to Add New Inventory Item
        btnMiddle.Text = "Add New Inventory Item"

        ' Show the middle button
        btnMiddle.Visible = True

        ' Disable all inputs
        DisableInputs()

        ' Display the current item
        DisplayItem(intCurrentItem)
    End Sub

    Private Sub ClearInputs()
        '------------------------------------------------------------
        '-                Subprogram  Name: ClearInputs             -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 11, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- Clear all the inputs                                     -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' Clear all the inputs
        txtManufacturer.Text = ""
        txtForm.Text = ""
        txtProcessor.Text = ""
        txtRam.Text = ""
        txtVideo.Text = ""
        txtVram.Text = ""
        txtHdd.Text = ""
        cbWireless.Checked = False
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        ' If the user is in save mode
        ' verify the data and save it

        ' Print a console message
        Console.WriteLine("Left button clicked!")

        Console.WriteLine("SAVE MODE: " & blnSaveMode)

        If Not blnSaveMode Then
            ' Print a console message
            Console.WriteLine("Previous button clicked!")

            Console.WriteLine("CURRENT INDEX " & intCurrentItem)
            Console.WriteLine("MAX INDEX " & aInventory.Length - 1)

            ' If we're not at index 0, go to the previous item
            If intCurrentItem > 0 Then
                intCurrentItem -= 1
                ' Display the current item
                DisplayItem(intCurrentItem)
            Else
                ' Create a message box to tell the user they're at the first item
                MessageBox.Show("You cannot move past the first record.")
            End If
        Else
            ' Print a console message
            Console.WriteLine("Save button clicked!")

            ' Verify the data
            If VerifyData() Then
                ' Save the data
                SaveData()
            End If
        End If

    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        ' If the user is in save mode
        ' set save mode to false
        ' and clear the inputs

        ' Print a console message
        Console.WriteLine("Right button clicked!")

        Console.WriteLine("SAVE MODE: " & blnSaveMode)

        If Not blnEmptyInventory Then
            If Not blnSaveMode Then
                ' Print a console message
                Console.WriteLine("Next button clicked!")

                Console.WriteLine("CURRENT INDEX " & intCurrentItem)
                Console.WriteLine("MAX INDEX " & aInventory.Length - 1)

                ' If we're not at the last item, go to the next item
                If intCurrentItem < aInventory.Length - 1 Then
                    intCurrentItem += 1
                    Console.WriteLine("CURRENT INDEX " & intCurrentItem)
                    ' Display the current item
                    DisplayItem(intCurrentItem)
                Else
                    ' Create a message box to tell the user they're at the last item
                    MessageBox.Show("You cannot move past the last record.")
                End If
            Else
                ' Switch out of save mode
                blnSaveMode = False
                SaveModeDisabled()
            End If
        End If
    End Sub

    Private Sub btnMiddle_Click() Handles btnMiddle.Click
        '------------------------------------------------------------
        '-                Subprogram  Name: btnMiddle_Click         -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 11, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- If the user is not in save mode, enable save mode        -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' Sets save mode to true
        ' and clears the inputs

        ' Print a console message
        Console.WriteLine("Middle button clicked!")

        Console.WriteLine("SAVE MODE: " & blnSaveMode)

        ' Switch to save mode
        blnSaveMode = True
        saveModeEnabled()
        ChangeFormTitle()
    End Sub

    Private Sub DisableInputs()
        '------------------------------------------------------------
        '-                Subprogram  Name: DisableInputs           -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 11, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- Disable all the inputs                                   -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' Set all inputs to readonly
        txtManufacturer.ReadOnly = True
        txtForm.ReadOnly = True
        txtProcessor.ReadOnly = True
        txtRam.ReadOnly = True
        txtVideo.ReadOnly = True
        txtVram.ReadOnly = True
        txtHdd.ReadOnly = True
        cbWireless.Enabled = False
    End Sub

    Private Sub EnableInputs()
        '------------------------------------------------------------
        '-                Subprogram  Name: EnableInputs            -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 11, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- Enable all the inputs                                    -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' Set all inputs to readonly
        txtManufacturer.ReadOnly = False
        txtForm.ReadOnly = False
        txtProcessor.ReadOnly = False
        txtRam.ReadOnly = False
        txtVideo.ReadOnly = False
        txtVram.ReadOnly = False
        txtHdd.ReadOnly = False
        cbWireless.Enabled = True
    End Sub

    Private Sub DisplayItem(ByVal intCurrentItemIndex As Integer)
        '------------------------------------------------------------
        '-                Subprogram  Name: DisplayItem             -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 11, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- Display the current item                                 -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- intCurrentItemIndex - The index of the current item      -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        Console.WriteLine("DISPLAYING ITEM INDEX " & intCurrentItemIndex)

        ' Display the current item in the inputs
        txtManufacturer.Text = aInventory(intCurrentItemIndex).strManufacturer
        txtForm.Text = aInventory(intCurrentItemIndex).strForm
        txtProcessor.Text = aInventory(intCurrentItemIndex).strProcessor
        txtVideo.Text = aInventory(intCurrentItemIndex).strVideo
        cbWireless.Checked = aInventory(intCurrentItemIndex).blnWireless


        If blnDisplayBytes Then
            txtRam.Text = aInventory(intCurrentItemIndex).dblMemoryBytes
            txtVram.Text = aInventory(intCurrentItemIndex).dblVideoMemoryBytes
            txtHdd.Text = aInventory(intCurrentItemIndex).dblStorageBytes
        Else
            txtRam.Text = aInventory(intCurrentItemIndex).sngMemoryGB
            txtVram.Text = aInventory(intCurrentItemIndex).sngVideoMemoryGB
            txtHdd.Text = aInventory(intCurrentItemIndex).sngStorageGB
        End If
        ' Update the form title
        ChangeFormTitle()
    End Sub

    Private Sub cbBytes_CheckedChanged() Handles cbBytes.CheckedChanged
        '------------------------------------------------------------
        '-                Subprogram  Name: cbBytes_CheckedChanged  -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 11, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- Change whether GB or B is display for the various 
        '  storage inputs                                          -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' If the user checks the bytes checkbox
        ' set the bytes boolean to true
        ' and uncheck the gigabytes checkbox

        ' Print a console message
        Console.WriteLine("Bytes checkbox clicked!")

        If Not blnSaveMode Then
            ' Set blnDisplayBytes to inverse
            blnDisplayBytes = Not blnDisplayBytes

            ' Redisplay the current item
            DisplayItem(intCurrentItem)
        Else
            blnDisplayBytes = Not blnDisplayBytes

            If blnDisplayBytes Then
                ' If the ram input is a number
                ' take the input and convert it from GB to B
                If IsNumeric(txtRam.Text) Then
                    txtRam.Text = txtRam.Text * gintGB_BYTE_CONVERSION
                End If

                ' If the vram input is a number
                ' take the input and convert it from GB to B
                If IsNumeric(txtVram.Text) Then
                    txtVram.Text = txtVram.Text * gintGB_BYTE_CONVERSION
                End If

                ' If the hdd input is a number
                ' take the input and convert it from GB to B
                If IsNumeric(txtHdd.Text) Then
                    txtHdd.Text = txtHdd.Text * gintGB_BYTE_CONVERSION
                End If
            Else
                ' If the ram input is a number
                ' take the input and convert it from B to GB
                If IsNumeric(txtRam.Text) Then
                    txtRam.Text = txtRam.Text / gintGB_BYTE_CONVERSION
                End If

                ' If the vram input is a number
                ' take the input and convert it from B to GB
                If IsNumeric(txtVram.Text) Then
                    txtVram.Text = txtVram.Text / gintGB_BYTE_CONVERSION
                End If

                ' If the hdd input is a number
                ' take the input and convert it from B to GB
                If IsNumeric(txtHdd.Text) Then
                    txtHdd.Text = txtHdd.Text / gintGB_BYTE_CONVERSION
                End If
            End If
        End If
    End Sub

    Private Sub ChangeFormTitle()
        '------------------------------------------------------------
        '-                Subprogram  Name: ChangeFormTitle         -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 11, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- Change the form title to reflect the current item        
        '  and save mode                                            -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------


        ' Change the form title to reflect the current mode
        ' and current item out of the total number of 
        ' items in the inventory

        ' Print a console message
        Console.WriteLine("Changing form title!")

        If blnSaveMode Then
            ' Set the title New Item Mode
            Me.Text = "IT Inventory Tracker - New Item Entry Screen"
        Else
            Me.Text = "IT Inventory Tracker - Item " & intCurrentItem + 1 & "/" & aInventory.Length
        End If
    End Sub

    Private Function VerifyData() As Boolean
        '------------------------------------------------------------
        '-                Subprogram  Name: VerifyData              -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 11, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -   
        '-                                                          -
        '- Verify that the data in the inputs is valid              -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' I believe you said we don't have to worry
        ' about manufacturer and form being empty
        ' so I'll allow those to be null

        ' Verify inputs don't exist 50 characters. This is set in the designer properties
        ' too but I'm doing this as an extra precaution

        ' Verify manufacturer is not more than 50 characters
        If txtManufacturer.Text.Length > 50 Then
            MessageBox.Show("Manufacturer cannot be more than 100 characters!")
            txtManufacturer.Focus()
            Return False
        End If

        ' Verify that form is not more than 50 characters
        If txtForm.Text.Length > 50 Then
            MessageBox.Show("Form cannot be more than 100 characters!")
            txtForm.Focus()
            Return False
        End If

        ' Verify that processor is not more than 50 characters
        If txtProcessor.Text.Length > 50 Then
            MessageBox.Show("Processor cannot be more than 50 characters!")
            txtProcessor.Focus()
            Return False
        End If

        ' Verify that video is not more than 50 characters
        If txtVideo.Text.Length > 50 Then
            MessageBox.Show("Video cannot be more than 50 characters!")
            txtVideo.Focus()
            Return False
        End If

        ' Verify that ram is not more than 50 characters
        If txtRam.Text.Length > 50 Then
            MessageBox.Show("RAM cannot be more than 50 characters!")
            txtRam.Focus()
            Return False
        End If

        ' Verify that ram is a number
        If Not IsNumeric(txtRam.Text) Then
            MessageBox.Show("RAM must be a number!")
            txtRam.Focus()
            Return False
        End If


        ' Verify that vram is not more than 50 characters
        If txtVram.Text.Length > 50 Then
            MessageBox.Show("VRAM cannot be more than 50 characters!")
            txtVram.Focus()
            Return False
        End If

        ' Verify that vram is a number
        If Not IsNumeric(txtVram.Text) Then
            MessageBox.Show("VRAM must be a number!")
            txtVram.Focus()
            Return False
        End If

        ' Verify that hdd is not more than 50 characters
        If txtHdd.Text.Length > 50 Then
            MessageBox.Show("HDD cannot be more than 50 characters!")
            txtHdd.Focus()
            Return False
        End If

        ' Verify that hdd is a number
        If Not IsNumeric(txtHdd.Text) Then
            MessageBox.Show("HDD must be a number!")
            txtHdd.Focus()
            Return False
        End If

        ' Everything look good
        ' Print a console message
        Console.WriteLine("Data verified!")
        ' Save the data
        Return True
    End Function

    Private Sub SaveData()
        '------------------------------------------------------------
        '-                Subprogram  Name: SaveData                -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 11, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- Save the data in the inputs to the inventory array       -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- newInventoryItem - The new inventory item to be added    -
        '------------------------------------------------------------

        ' Print a console message
        Console.WriteLine("Saving data!")

        ' If aInventory is not nothing
        If aInventory IsNot Nothing Then
            ' Redim +1 the array
            ReDim Preserve aInventory(aInventory.Length)
        Else
            ReDim aInventory(0)
        End If

        ' Assign the new inventory item to the last index
        aInventory(aInventory.Length - 1).strManufacturer = txtManufacturer.Text
        aInventory(aInventory.Length - 1).strForm = txtForm.Text
        aInventory(aInventory.Length - 1).strProcessor = txtProcessor.Text
        aInventory(aInventory.Length - 1).strVideo = txtVideo.Text
        aInventory(aInventory.Length - 1).blnWireless = cbWireless.Checked

        ' If cbBytes is checked
        ' then save the bytes variable and convert the input to GB
        ' then save the GB variable
        ' else save the GB variable and convert the input to bytes
        ' then save the bytes variable
        If cbBytes.Checked Then
            aInventory(aInventory.Length - 1).dblMemoryBytes = txtRam.Text
            aInventory(aInventory.Length - 1).sngMemoryGB = txtRam.Text / gintGB_BYTE_CONVERSION
            aInventory(aInventory.Length - 1).dblVideoMemoryBytes = txtVram.Text
            aInventory(aInventory.Length - 1).sngVideoMemoryGB = txtVram.Text / gintGB_BYTE_CONVERSION
            aInventory(aInventory.Length - 1).dblStorageBytes = txtHdd.Text
            aInventory(aInventory.Length - 1).sngStorageGB = txtHdd.Text / gintGB_BYTE_CONVERSION
        Else
            aInventory(aInventory.Length - 1).dblMemoryBytes = txtRam.Text * gintGB_BYTE_CONVERSION
            aInventory(aInventory.Length - 1).sngMemoryGB = txtRam.Text
            aInventory(aInventory.Length - 1).dblVideoMemoryBytes = txtVram.Text * gintGB_BYTE_CONVERSION
            aInventory(aInventory.Length - 1).sngVideoMemoryGB = txtVram.Text
            aInventory(aInventory.Length - 1).dblStorageBytes = txtHdd.Text * gintGB_BYTE_CONVERSION
            aInventory(aInventory.Length - 1).sngStorageGB = txtHdd.Text
        End If

        ' Set the new current item to 0
        intCurrentItem = 0
        ' Inventory isn't empty
        blnEmptyInventory = False
        ' Disable save mode and switch to viewing mode
        blnSaveMode = False
        SaveModeDisabled()

        ' Save the data to the file
        SaveDataToFile()

    End Sub

    Private Sub SaveDataToFile()
        '------------------------------------------------------------
        '-                Subprogram  Name: SaveDataToFile          -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 11, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- Save the data in the inventory array to the file         -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        Console.WriteLine("CURRENT LENGTH : " & aInventory.Length)
        ' Append the last element from the aInventory array
        ' to the file while seperating each attribute with a tab
        File.AppendAllText("inventory.txt", aInventory(aInventory.Length - 1).strManufacturer & vbTab &
                           aInventory(aInventory.Length - 1).strForm & vbTab &
                           aInventory(aInventory.Length - 1).strProcessor & vbTab &
                           aInventory(aInventory.Length - 1).sngMemoryGB & vbTab &
                           aInventory(aInventory.Length - 1).dblMemoryBytes & vbTab &
                           aInventory(aInventory.Length - 1).strVideo & vbTab &
                           aInventory(aInventory.Length - 1).sngVideoMemoryGB & vbTab &
                           aInventory(aInventory.Length - 1).dblVideoMemoryBytes & vbTab &
                           aInventory(aInventory.Length - 1).sngStorageGB & vbTab &
                           aInventory(aInventory.Length - 1).dblStorageBytes & vbTab &
                           aInventory(aInventory.Length - 1).blnWireless & vbNewLine)
    End Sub
End Class
