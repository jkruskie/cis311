Public Class frmComputerConfig

    '------------------------------------------------------------
    '-                File Name : frmComputerConfig.frm         - 
    '-                Part of Project: ComputerConfigurator     -
    '------------------------------------------------------------
    '-                Written By: Justin T. Kruskie             -
    '-                Written On: January 18, 2023              -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file contains the main form for the application     - 
    '- that allows the user to configure a computer.            -
    '- All computer configuration and variables are stored in   -
    '- this form.                                               -
    '------------------------------------------------------------
    '- Program Purpose:                                         -
    '-                                                          -
    '- The purpose of this program is to handle the creation of -
    '- a computer order. The user can select between different  -
    '- options for each part of the computer and the program    -
    '- will calculate the total price of the computer.          -
    '------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):             -
    '- aInventory - An array of InventoryItem objects that      -
    '-              contains all of the items in the inventory. -
    '- strFormFactor - A string that contains the form factor   -
    '-                 of the computer.                         -
    '------------------------------------------------------------

    '---------------------------------------------------------------------------------------
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '---------------------------------------------------------------------------------------
    Dim Inventory() As Inventory
    Dim strFormFactor As String

    '-----------------------------------------------------------------------------------
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------
    Private Sub frmComputerConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '------------------------------------------------------------
        '-            Subprogram Name: frmComputerConfig_Load       -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 18, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram is called when the form is loaded. It   -
        '- loads the inventory from the Inventory class and        -
        '- displays the form factor options.                        -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram.          -
        '- e - The event arguments.                                 -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------
        ' Load the inventory items
        Inventory = New Inventory().LoadItems()
        ' Console log the total number of inventory items
        Console.WriteLine("Total inventory items: " & Inventory.Length)

        ' Check the desktop radio button
        radDesktop.Checked = True
        ' Set the form factor to desktop
        strFormFactor = "Desktop"

        ' Set the default radio boxes
        Reset()

        ' Change all the labels to desktop
        DisplayDesktopInventory()
    End Sub

    ' Create new empty computer object
    Dim objComputer As New Computer

    Private Sub radDesktop_CheckedChanged(sender As Object, e As EventArgs) Handles radDesktop.CheckedChanged
        '------------------------------------------------------------
        '-            Subprogram Name: radDesktop_CheckedChanged    -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 18, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram is called when the desktop radio button -
        '- is checked. It changes the form factor to desktop and    -
        '- displays the desktop inventory.                          -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram.          -
        '- e - The event arguments.                                 -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------
        ' Set the form factor to desktop
        DisplayDesktopInventory()
    End Sub

    Private Sub radNotebook_CheckedChanged(sender As Object, e As EventArgs) Handles radNotebook.CheckedChanged
        '------------------------------------------------------------
        '-            Subprogram Name: radNotebook_CheckedChanged   -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 18, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram is called when the notebook radio button -
        '- is checked. It changes the form factor to notebook and   -
        '- displays the notebook inventory.                         -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram.          -
        '- e - The event arguments.                                 -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------
        ' Set the form factor to notebook
        DisplayNotebookInventory()
    End Sub

    Private Sub radTablet_CheckedChanged(sender As Object, e As EventArgs) Handles radTablet.CheckedChanged
        '------------------------------------------------------------
        '-            Subprogram Name: radTablet_CheckedChanged     -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 18, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram is called when the tablet radio button   -
        '- is checked. It changes the form factor to tablet and     -
        '- displays the tablet inventory.                           -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram.          -
        '- e - The event arguments.                                 -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------
        ' Set the form factor to tablet
        DisplayTabletInventory()
    End Sub


    Private Sub DisplayDesktopInventory()
        '------------------------------------------------------------
        '-            Subprogram Name: DisplayDesktopInventory      -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 18, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram is called when the form factor is        -
        '- changed to desktop. It displays the desktop inventory.   -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' Console log
        Console.WriteLine("Displaying desktop inventory")
        ' Adjust the visibility of all items
        ' Set the visibility of all memory radio boxes to true
        radMemory1.Visible = True
        radMemory2.Visible = True
        radMemory3.Visible = True
        radMemory1.Checked = True
        ' Set the visibility of all storage radio boxes to true
        radStorage1.Visible = True
        radStorage2.Visible = True
        radStorage3.Visible = True
        radStorage1.Checked = True
        ' Set the visibility of cbSoundCard to true
        cbSoundCard.Visible = True
        cbSoundCard.Checked = False
        ' Set the visibility of cbLiquidCooling to true
        cbLiquidCooling.Visible = True
        cbLiquidCooling.Checked = False
        ' Set the visibility of cbDvdRom to true
        cbDvdRom.Visible = True
        cbDvdRom.Checked = False
        ' Set visibility of cbInternalCamera to false
        cbInternalCamera.Visible = False
        cbInternalCamera.Checked = False

        ' Set the text of all video card radio boxes
        radVideoCard1.Text = Inventory.GetValue(0).arrGraphics.GetValue(0).strType
        radVideoCard2.Text = Inventory.GetValue(0).arrGraphics.GetValue(1).strType

        ' Set the visibility of all video card radio boxes to true
        radVideoCard1.Visible = True
        radVideoCard2.Visible = True
        radVideoCard1.Checked = True

        ' Set the text of all memory radio boxes
        ' If the sizes are >= 1000, use TB instead of GB
        If Inventory.GetValue(0).arrMemory.GetValue(0).intCapacity >= 1000 Then
            radMemory1.Text = Inventory.GetValue(0).arrMemory.GetValue(0).intCapacity / 1000 & " TB"
        Else
            radMemory1.Text = Inventory.GetValue(0).arrMemory.GetValue(0).intCapacity & " GB"
        End If
        If Inventory.GetValue(0).arrMemory.GetValue(1).intCapacity >= 1000 Then
            radMemory2.Text = Inventory.GetValue(0).arrMemory.GetValue(1).intCapacity / 1000 & " TB"
        Else
            radMemory2.Text = Inventory.GetValue(0).arrMemory.GetValue(1).intCapacity & " GB"
        End If
        If Inventory.GetValue(0).arrMemory.GetValue(2).intCapacity >= 1000 Then
            radMemory3.Text = Inventory.GetValue(0).arrMemory.GetValue(2).intCapacity / 1000 & " TB"
        Else
            radMemory3.Text = Inventory.GetValue(0).arrMemory.GetValue(2).intCapacity & " GB"
        End If

        ' Set the text of all storage radio boxes
        ' If the sizes are >= 1000, use TB instead of GB
        If Inventory.GetValue(0).arrStorage.GetValue(0).intCapacity >= 1000 Then
            radStorage1.Text = Inventory.GetValue(0).arrStorage.GetValue(0).intCapacity / 1000 & " TB"
        Else
            radStorage1.Text = Inventory.GetValue(0).arrStorage.GetValue(0).intCapacity & " GB"
        End If
        If Inventory.GetValue(0).arrStorage.GetValue(1).intCapacity >= 1000 Then
            radStorage2.Text = Inventory.GetValue(0).arrStorage.GetValue(1).intCapacity / 1000 & " TB"
        Else
            radStorage2.Text = Inventory.GetValue(0).arrStorage.GetValue(1).intCapacity & " GB"
        End If
        If Inventory.GetValue(0).arrStorage.GetValue(2).intCapacity >= 1000 Then
            radStorage3.Text = Inventory.GetValue(0).arrStorage.GetValue(2).intCapacity / 1000 & " TB"
        Else
            radStorage3.Text = Inventory.GetValue(0).arrStorage.GetValue(2).intCapacity & " GB"
        End If

        ' Set the text of all processor radio boxes
        radProcessor1.Text = Inventory.GetValue(0).arrProcessor.GetValue(0).strType
        radProcessor2.Text = Inventory.GetValue(0).arrProcessor.GetValue(1).strType
    End Sub

    Private Sub DisplayNotebookInventory()
        '------------------------------------------------------------
        '-            Subprogram Name: DisplayNotebookInventory     -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 18, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram is called when the form factor is        -
        '- changed to notebook. It displays the notebook inventory. -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' Console log
        Console.WriteLine("Displaying notebook inventory")
        ' Set the visibility of the 1st and 2nd memory radio boxes to true
        radMemory1.Visible = True
        radMemory2.Visible = True
        ' Set the visibility of the third memory radio box to dalse
        radMemory3.Visible = False
        ' Set the first to checked
        radMemory1.Checked = True

        If Inventory.GetValue(1).arrMemory.GetValue(0).intCapacity >= 1000 Then
            radMemory1.Text = Inventory.GetValue(1).arrMemory.GetValue(0).intCapacity / 1000 & " TB"
        Else
            radMemory1.Text = Inventory.GetValue(1).arrMemory.GetValue(0).intCapacity & " GB"
        End If
        If Inventory.GetValue(1).arrMemory.GetValue(1).intCapacity >= 1000 Then
            radMemory2.Text = Inventory.GetValue(1).arrMemory.GetValue(1).intCapacity / 1000 & " TB"
        Else
            radMemory2.Text = Inventory.GetValue(1).arrMemory.GetValue(1).intCapacity & " GB"
        End If

        ' Set the visibility of the 1st and 2nd storage radio boxes to true
        radStorage1.Visible = True
        radStorage2.Visible = True
        ' Set the visibility of the third storage radio box to false
        radStorage3.Visible = False
        ' Set the first to checked
        radStorage1.Checked = True

        ' Set the text of all storage radio boxes
        ' If the sizes are >= 1000, use TB instead of GB
        If Inventory.GetValue(1).arrStorage.GetValue(0).intCapacity >= 1000 Then
            radStorage1.Text = Inventory.GetValue(1).arrStorage.GetValue(0).intCapacity / 1000 & " TB"
        Else
            radStorage1.Text = Inventory.GetValue(1).arrStorage.GetValue(0).intCapacity & " GB"
        End If
        If Inventory.GetValue(1).arrStorage.GetValue(1).intCapacity >= 1000 Then
            radStorage2.Text = Inventory.GetValue(1).arrStorage.GetValue(1).intCapacity / 1000 & " TB"
        Else
            radStorage2.Text = Inventory.GetValue(1).arrStorage.GetValue(1).intCapacity & " GB"
        End If

        ' Set the visibility of the 1st and 2nd storage radio boxes to true
        radStorage1.Visible = True
        radStorage2.Visible = True
        radStorage1.Checked = True
        ' Set the visibility of the third storage radio box to false
        radStorage3.Visible = False
        ' Set visibility of cbSoundCarrd to false
        cbSoundCard.Visible = False
        cbSoundCard.Checked = False
        ' Set visibility of cbLiquidCooling to true
        cbLiquidCooling.Visible = True
        cbLiquidCooling.Checked = False
        ' Set visibility of cbDvdRom to true
        cbDvdRom.Visible = True
        cbDvdRom.Checked = False
        ' Set the visibility of cbInternalCamera to true
        cbInternalCamera.Visible = True
        cbInternalCamera.Checked = False

        ' Set the text of all processor radio boxes
        radProcessor1.Text = Inventory.GetValue(1).arrProcessor.GetValue(0).strType
        radProcessor2.Text = Inventory.GetValue(1).arrProcessor.GetValue(1).strType
    End Sub

    Private Sub DisplayTabletInventory()
        '------------------------------------------------------------
        '-            Subprogram Name: DisplayTabletInventory       -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 18, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram is called when the form factor is        -
        '- changed to tablet. It displays the tablet inventory.     -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' Console log
        Console.WriteLine("Displaying tablet inventory")
        ' Set visibility of all video card radio boxes to false
        radVideoCard1.Visible = False
        radVideoCard2.Visible = False
        radVideoCard1.Checked = False
        radVideoCard2.Checked = False
        ' Set the visibility of all memory radio boxes to false
        radMemory1.Visible = False
        radMemory2.Visible = False
        radMemory3.Visible = False
        radMemory1.Checked = False
        radMemory2.Checked = False
        radMemory3.Checked = False
        ' Set the visibility of all storage radio boxes to true
        radStorage1.Visible = True
        radStorage2.Visible = True
        radStorage3.Visible = True
        radStorage1.Checked = True

        ' Set the text of all storage radio boxes
        ' If the sizes are >= 1000, use TB instead of GB
        If Inventory.GetValue(2).arrStorage.GetValue(0).intCapacity >= 1000 Then
            radStorage1.Text = Inventory.GetValue(2).arrStorage.GetValue(0).intCapacity / 1000 & " TB"
        Else
            radStorage1.Text = Inventory.GetValue(2).arrStorage.GetValue(0).intCapacity & " GB"
        End If
        If Inventory.GetValue(2).arrStorage.GetValue(1).intCapacity >= 1000 Then
            radStorage2.Text = Inventory.GetValue(2).arrStorage.GetValue(1).intCapacity / 1000 & " TB"
        Else
            radStorage2.Text = Inventory.GetValue(2).arrStorage.GetValue(1).intCapacity & " GB"
        End If
        If Inventory.GetValue(2).arrStorage.GetValue(2).intCapacity >= 1000 Then
            radStorage3.Text = Inventory.GetValue(2).arrStorage.GetValue(2).intCapacity / 1000 & " TB"
        Else
            radStorage3.Text = Inventory.GetValue(2).arrStorage.GetValue(2).intCapacity & " GB"
        End If

        ' Set the visibility of cbSoundCard to false
        cbSoundCard.Visible = False
        cbSoundCard.Checked = False
        ' Set the visibility of cbDvdRom to false
        cbDvdRom.Visible = False
        cbDvdRom.Checked = False
        ' Set the visibility of cbInternalCamera to true
        cbInternalCamera.Visible = True
        cbInternalCamera.Checked = False

        ' Set the text of all processor radio boxes
        radProcessor1.Text = Inventory.GetValue(2).arrProcessor.GetValue(0).strType
        radProcessor2.Text = Inventory.GetValue(2).arrProcessor.GetValue(1).strType
    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnPlaceOrder_Click          -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 18, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram is called when the place order button is -
        '- clicked. It places the order.                            -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the subprogram           -
        '- e - The event arguments                                  -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- objComputer - The computer object                        -
        '------------------------------------------------------------

        ' Ensure quanitity is not empty
        If txtQuantity.Text = "" Then
            MessageBox.Show("Please enter a quantity")
            Exit Sub
        End If

        ' Create computer
        Dim objComputer As Computer = CreateComputer()

        ' Hide the current form and show the invoice form
        ' and send it the computer
        Console.WriteLine("Hiding current form and showing invoice form")
        Me.Hide()
        frmInvoice.Show()
        frmInvoice.DisplayInvoice(objComputer)



    End Sub

    Private Function CreateComputer() As Computer
        '------------------------------------------------------------
        '-            Subprogram Name: CreateComputer               -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 23, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram is called when the place order button is -
        '- clicked. It creates a computer object and returns it.     -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- objComputer - The computer object                        -
        '------------------------------------------------------------
        '- Returns:                                                 -
        '- objComputer - The computer object                        -
        '------------------------------------------------------------

        ' Create new instance of computer
        Dim newComputer As New Computer

        ' Set the customer name
        newComputer.strCustomerName = txtCustomerName.Text

        ' Set the quantity
        newComputer.intQuantity = CInt(txtQuantity.Text)

        ' Selected form factor index based on which rad button is selected
        Dim intSelectedFormFactor As Integer = GetSelectedFormFactor()

        ' Set the form factor
        If radDesktop.Checked Then
            newComputer.strFormFactor = Inventory.GetValue(intSelectedFormFactor).objFormFactor.strType
            newComputer.intFormFactorPrice = Inventory.GetValue(intSelectedFormFactor).objFormFactor.intPrice
        ElseIf radNotebook.Checked Then
            newComputer.strFormFactor = Inventory.GetValue(intSelectedFormFactor).objFormFactor.strType
            newComputer.intFormFactorPrice = Inventory.GetValue(intSelectedFormFactor).objFormFactor.intPrice
        ElseIf radTablet.Checked Then
            newComputer.strFormFactor = Inventory.GetValue(intSelectedFormFactor).objFormFactor.strType
            newComputer.intFormFactorPrice = Inventory.GetValue(intSelectedFormFactor).objFormFactor.intPrice
        End If

        ' Set the graphics card
        If radVideoCard1.Checked Then
            newComputer.strGraphicsCard = Inventory.GetValue(intSelectedFormFactor).arrGraphics.GetValue(0).strType
            newComputer.intGraphicsCardPrice = Inventory.GetValue(intSelectedFormFactor).arrGraphics.GetValue(0).intPrice
        ElseIf radVideoCard2.Checked Then
            newComputer.strGraphicsCard = Inventory.GetValue(intSelectedFormFactor).arrGraphics.GetValue(1).strType
            newComputer.intGraphicsCardPrice = Inventory.GetValue(intSelectedFormFactor).arrGraphics.GetValue(1).intPrice
        Else
            newComputer.strGraphicsCard = "None"
            newComputer.intGraphicsCardPrice = 0
        End If

        ' Set the memory
        If radMemory1.Checked Then
            newComputer.intMemory = Inventory.GetValue(intSelectedFormFactor).arrMemory.GetValue(0).intCapacity
            newComputer.intMemoryPrice = Inventory.GetValue(intSelectedFormFactor).arrMemory.GetValue(0).intPrice
        ElseIf radMemory2.Checked Then
            newComputer.intMemory = Inventory.GetValue(intSelectedFormFactor).arrMemory.GetValue(1).intCapacity
            newComputer.intMemoryPrice = Inventory.GetValue(intSelectedFormFactor).arrMemory.GetValue(1).intPrice
        ElseIf radMemory3.Checked Then
            newComputer.intMemory = Inventory.GetValue(intSelectedFormFactor).arrMemory.GetValue(2).intCapacity
            newComputer.intMemoryPrice = Inventory.GetValue(intSelectedFormFactor).arrMemory.GetValue(2).intPrice
        Else
            newComputer.intMemory = 0
            newComputer.intMemoryPrice = 0
        End If

        ' Set the storage
        If radStorage1.Checked Then
            newComputer.intStorage = Inventory.GetValue(intSelectedFormFactor).arrStorage.GetValue(0).intCapacity
            newComputer.intStoragePrice = Inventory.GetValue(intSelectedFormFactor).arrStorage.GetValue(0).intPrice
        ElseIf radStorage2.Checked Then
            newComputer.intStorage = Inventory.GetValue(intSelectedFormFactor).arrStorage.GetValue(1).intCapacity
            newComputer.intStoragePrice = Inventory.GetValue(intSelectedFormFactor).arrStorage.GetValue(1).intPrice
        ElseIf radStorage3.Checked Then
            newComputer.intStorage = Inventory.GetValue(intSelectedFormFactor).arrStorage.GetValue(2).intCapacity
            newComputer.intStoragePrice = Inventory.GetValue(intSelectedFormFactor).arrStorage.GetValue(2).intPrice
        Else
            newComputer.intStorage = 0
            newComputer.intStoragePrice = 0
        End If

        ' Set the processor
        If radProcessor1.Checked Then
            newComputer.strProcessor = Inventory.GetValue(intSelectedFormFactor).arrProcessor.GetValue(0).strType
            newComputer.intProcessorPrice = Inventory.GetValue(intSelectedFormFactor).arrProcessor.GetValue(0).intPrice
        ElseIf radProcessor2.Checked Then
            newComputer.strProcessor = Inventory.GetValue(intSelectedFormFactor).arrProcessor.GetValue(1).strType
            newComputer.intProcessorPrice = Inventory.GetValue(intSelectedFormFactor).arrProcessor.GetValue(1).intPrice
        Else
            newComputer.strProcessor = "None"
            newComputer.intProcessorPrice = 0
        End If

        ' Set the sound card
        If cbSoundCard.Checked Then
            newComputer.blnSoundCard = True
            newComputer.intSoundCardPrice = Inventory.GetValue(intSelectedFormFactor).objSoundCard.intPrice
        Else
            newComputer.blnSoundCard = False
            newComputer.intSoundCardPrice = 0
        End If

        ' Set the dvd rom
        If cbDvdRom.Checked Then
            newComputer.blnDvdRom = True
            newComputer.intDvdRomPrice = Inventory.GetValue(intSelectedFormFactor).objDVDRom.intPrice
        Else
            newComputer.blnDvdRom = False
            newComputer.intDvdRomPrice = 0
        End If

        ' Set the liquid cooling
        If cbLiquidCooling.Checked Then
            newComputer.blnLiquidCooling = True
            newComputer.intLiquidCoolingPrice = Inventory.GetValue(intSelectedFormFactor).objLiquidCooling.intPrice
        Else
            newComputer.blnLiquidCooling = False
            newComputer.intLiquidCoolingPrice = 0
        End If

        ' Return the computer
        Return newComputer
    End Function

    Private Function GetSelectedFormFactor() As Integer
        '------------------------------------------------------------
        '-                Function Name: GetSelectedFormFactor      -
        '------------------------------------------------------------
        '-                Written By: Justin Kruskie                -
        '-                Written On: January 23, 2023              - 
        '------------------------------------------------------------
        '- Subprogram Purpose:                                       -
        '-                                                          -
        '- This function returns the selected form factor index     -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Returns:                                                 -
        '- Integer - The selected form factor index                 -
        '------------------------------------------------------------

        ' Return the index of the selected form factor
        If radDesktop.Checked Then
            Return 0
        ElseIf radNotebook.Checked Then
            Return 1
        ElseIf radTablet.Checked Then
            Return 2
        End If
    End Function

    Public Sub Reset()
        '------------------------------------------------------------
        '-                Subprogram Name: Reset                    -
        '------------------------------------------------------------
        '-                Written By: Justin Kruskie                -
        '-                Written On: January 23, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                       -
        '-                                                          -
        '- This subprogram resets the form to its default state     -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)
        '------------------------------------------------------------

        ' Reset the form
        radDesktop.Checked = True
        txtCustomerName.Text = ""
        radDesktop.Checked = True
        radVideoCard1.Checked = True
        radMemory1.Checked = True
        radStorage1.Checked = True
        radProcessor1.Checked = True
        cbSoundCard.Checked = False
        cbDvdRom.Checked = False
        cbLiquidCooling.Checked = False
    End Sub
End Class
