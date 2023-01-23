Public Class frmInvoice
    '------------------------------------------------------------
    '-                File Name : frmComputerConfig.frm         - 
    '-                Part of Project: frmInvoice               -
    '------------------------------------------------------------
    '-                Written By: Justin T. Kruskie             -
    '-                Written On: January 23, 2023              -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file contains the code for the frmInvoice form.     -
    '- Which handles processing and display the invoice for the -
    '- customer.                                                -
    '------------------------------------------------------------
    '- Program Purpose:                                         -
    '-                                                          -
    '- The purpose of this program is to handle the creation of -
    '- a computer order. The user can select between different  -
    '- options for each part of the computer and the program    -
    '- will calculate the total price of the computer.          -
    '------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):             -
    '- (None)                                                   -
    '------------------------------------------------------------

    '-----------------------------------------------------------------------------------
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------
    Public Sub DisplayInvoice(ByVal objComputer As Computer)
        '------------------------------------------------------------
        '-                Subprogram Name: DisplayInvoice           -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 23, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram will display the invoice for the customer-
        '- based on the computer object passed in.                  -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- objComputer - The computer object to display the invoice -
        '-               for.                                       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' Console log
        Console.WriteLine("Opening invoice form")
        ' Console log computer
        ' Console.WriteLine(objComputer.ToString())

        rtbInvoice.AppendText("==========================================================" & vbNewLine)
        rtbInvoice.AppendText("Custom System for " & objComputer.strCustomerName & vbNewLine)
        rtbInvoice.AppendText("==========================================================" & vbNewLine)
        rtbInvoice.AppendText("Category".PadRight(15) & vbTab & "Item".PadRight(15) & vbTab & "Price".PadRight(15) & vbNewLine)
        rtbInvoice.AppendText("Form Factor".PadRight(15) & vbTab & objComputer.strFormFactor.PadRight(15) & vbTab & FormatCurrency(objComputer.intFormFactorPrice, 2).PadRight(15) & vbNewLine)
        If (objComputer.strFormFactor IsNot Nothing) Then
            rtbInvoice.AppendText("Graphics Card".PadRight(15) & vbTab & objComputer.strGraphicsCard.PadRight(15) & vbTab & FormatCurrency(objComputer.intGraphicsCardPrice, 2).PadRight(15) & vbNewLine)
        End If
        If (objComputer.intMemory >= 1000) Then
            rtbInvoice.AppendText("Memory".PadRight(15) & vbTab & (objComputer.intMemory / 1000 & "TB").PadRight(15) & vbTab & FormatCurrency(objComputer.intMemoryPrice, 2).PadRight(15) & vbNewLine)
        Else
            rtbInvoice.AppendText("Memory".PadRight(15) & vbTab & (objComputer.intMemory & "GB").PadRight(15) & vbTab & FormatCurrency(objComputer.intMemoryPrice, 2).PadRight(15) & vbNewLine)
        End If
        If (objComputer.intStorage >= 1000) Then
            rtbInvoice.AppendText("Storage".PadRight(15) & vbTab & (objComputer.intStorage / 1000 & "TB").PadRight(15) & vbTab & FormatCurrency(objComputer.intStoragePrice, 2).PadRight(15) & vbNewLine)
        Else
            rtbInvoice.AppendText("Storage".PadRight(15) & vbTab & (objComputer.intStorage & "GB").PadRight(15) & vbTab & FormatCurrency(objComputer.intStoragePrice, 2).PadRight(15) & vbNewLine)
        End If
        rtbInvoice.AppendText("Processor".PadRight(15) & vbTab & objComputer.strProcessor.PadRight(15) & vbTab & FormatCurrency(objComputer.intProcessorPrice, 2).PadLeft(23) & vbNewLine)
        If (objComputer.blnDvdRom) Then
            rtbInvoice.AppendText("DVD-ROM".PadRight(15) & vbTab & objComputer.blnDvdRom.ToString().PadRight(15) & vbTab & FormatCurrency(objComputer.intDvdRomPrice, 2).PadRight(15) & vbNewLine)
        End If
        If (objComputer.blnSoundCard) Then
            rtbInvoice.AppendText("Sound Card".PadRight(15) & vbTab & objComputer.blnSoundCard.ToString().PadRight(15) & vbTab & FormatCurrency(objComputer.intSoundCardPrice, 2).PadRight(15) & vbNewLine)
        End If
        If (objComputer.blnLiquidCooling) Then
            rtbInvoice.AppendText("Liquid Cooling".PadRight(15) & vbTab & objComputer.blnLiquidCooling.ToString().PadRight(15) & vbTab & FormatCurrency(objComputer.intLiquidCoolingPrice, 2).PadRight(15) & vbNewLine)
        End If
        rtbInvoice.AppendText("==========================================================" & vbNewLine)
        rtbInvoice.AppendText("Cost Per Unit: " & FormatCurrency(CostPerUnit(objComputer), 2) & vbNewLine)
        rtbInvoice.AppendText("Quantity: " & objComputer.intQuantity & vbNewLine)
        rtbInvoice.AppendText("==========================================================" & vbNewLine)
        rtbInvoice.AppendText("Total Cost: " & FormatCurrency(TotalCost(objComputer), 2) & vbNewLine)
        rtbInvoice.AppendText("==========================================================" & vbNewLine)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        '------------------------------------------------------------
        '-                Subprogram Name: btnExit_Click            -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 23, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram will close the application.              -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the event.               -
        '- e - The event arguments.                                 -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' Prompt user to confirm exit
        If MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ' Close form
            Me.Close()
            ' Close parent form
            frmComputerConfig.Close()
        End If
    End Sub

    Private Sub btnProcessOrder_Click(sender As Object, e As EventArgs) Handles btnProcessOrder.Click
        '------------------------------------------------------------
        '-               Subprogram Name: btnProcessOrder_Click    
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 23, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram will process the order and return the    -
        '- user back to the main form.                              -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the event.               -
        '- e - The event arguments.                                 -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' Inform user the order has been processed
        MessageBox.Show("Your order has been processed!", "Order Processed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Close the form and tell the parent form to reset
        Me.Close()
        frmComputerConfig.Show()
        frmComputerConfig.Reset()
    End Sub

    Private Sub frmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '------------------------------------------------------------
        '-                Subprogram Name: frmInvoice_Load          -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 23, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram will load the invoice form.              -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the event.               -
        '- e - The event arguments.                                 -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        Me.ControlBox = False
    End Sub

    Private Sub btnChangeOrder_Click(sender As Object, e As EventArgs) Handles btnChangeOrder.Click
        '------------------------------------------------------------
        '-               Subprogram Name: btnChangeOrder_Click      -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 23, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram will return the user back to the main    -
        '- form to change their order.                              -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender - The object that called the event.               -
        '- e - The event arguments.                                 -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' Close the form and return to the parent
        Me.Close()
        frmComputerConfig.Show()
    End Sub

    Private Function CostPerUnit(ByVal objComputer As Computer) As Double
        '------------------------------------------------------------
        '-                Function Name: CostPerUnit                -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 23, 2023              -
        '------------------------------------------------------------
        '- Function Purpose:                                        -
        '-                                                          -
        '- This function will calculate the cost per unit of the    -
        '- computer.                                                -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- objComputer - The computer object.                       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- dblCostPerUnit - The cost per unit of the computer.      -
        '------------------------------------------------------------
        '- Returns:                                                 -
        '- dblCostPerUnit - The cost per unit of the computer.      -
        '------------------------------------------------------------

        ' Calculate the cost for all the components
        Dim dblCost As Double = objComputer.intFormFactorPrice + objComputer.intGraphicsCardPrice + objComputer.intMemoryPrice + objComputer.intProcessorPrice + objComputer.intStoragePrice + objComputer.intDvdRomPrice + objComputer.intSoundCardPrice + objComputer.intLiquidCoolingPrice
        ' Return the cost
        Return dblCost
    End Function

    Private Function TotalCost(ByVal objComputer As Computer) As Double
        '------------------------------------------------------------
        '-                Function Name: TotalCost                  -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 23, 2023              -
        '------------------------------------------------------------
        '- Function Purpose:                                        -
        '-                                                          -
        '- This function will calculate the total cost of the       -
        '- computer.                                                -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -   
        '- objComputer - The computer object.                       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- dblTotalCost - The total cost of the computer.           -
        '------------------------------------------------------------
        '- Returns:                                                 -
        '- dblTotalCost - The total cost of the computer.           -
        '------------------------------------------------------------

        ' Calculate the total cost
        Dim dblTotalCost As Double = CostPerUnit(objComputer) * objComputer.intQuantity
        ' Return the total cost
        Return dblTotalCost
    End Function
End Class