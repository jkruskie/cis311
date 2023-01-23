Public Class Computer
    '------------------------------------------------------------
    '-                File Name : Computer.vb                   -
    '-                Part of Project: Assignment2              -
    '------------------------------------------------------------
    '-                Written By: Justin T. Kruskie             -
    '-                Written On: January 18, 2023              -
    '-----------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file handles the creation of the Computer class     -
    '- and the creation of the computer object which holds the  -
    '- computer parts.                                          -
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

    Public strCustomerName As String
    Public intQuantity As Integer
    Public strFormFactor As String
    Public intFormFactorPrice As Integer
    Public strGraphicsCard As String
    Public intGraphicsCardPrice As Integer
    Public intMemory As Integer
    Public intMemoryPrice As Integer
    Public intStorage As Integer
    Public intStoragePrice As Integer
    Public strProcessor As String
    Public intProcessorPrice As Integer
    Public blnDvdRom As Boolean
    Public intDvdRomPrice As Integer
    Public blnSoundCard As Boolean
    Public intSoundCardPrice As Integer
    Public blnLiquidCooling As Boolean
    Public intLiquidCoolingPrice As Integer

    Public Sub New()
        '------------------------------------------------------------
        '-                Subprogram Name: New                      -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 18, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram is the constructor for the Computer      -
        '- class.                                                   -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        strCustomerName = ""
        strFormFactor = ""
        intFormFactorPrice = 0
        strGraphicsCard = ""
        intGraphicsCardPrice = 0
        intMemory = 0
        intMemoryPrice = 0
        intStorage = 0
        intStoragePrice = 0
        strProcessor = ""
        intProcessorPrice = 0
        blnDvdRom = False
        intDvdRomPrice = 0
        blnSoundCard = False
        intSoundCardPrice = 0
        blnLiquidCooling = False
        intLiquidCoolingPrice = 0
    End Sub

    Public Overrides Function ToString() As String
        '------------------------------------------------------------
        '-                Function Name: ToString                   -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 18, 2023              -
        '------------------------------------------------------------
        '- Function Purpose:                                        -
        '-                                                          -
        '- This function returns the information about the computer -
        '- object.                                                  -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Returns:                                                 -
        '- String - The information about the computer object.      -
        '------------------------------------------------------------

        Return strCustomerName & " " & strFormFactor & " " & intFormFactorPrice & " " & strGraphicsCard & " " & intGraphicsCardPrice & " " & intMemory & " " & intMemoryPrice & " " & intStorage & " " & intStoragePrice & " " & strProcessor & " " & intProcessorPrice & " " & blnDvdRom & " " & intDvdRomPrice & " " & blnSoundCard & " " & intSoundCardPrice & " " & blnLiquidCooling & " " & intLiquidCoolingPrice
    End Function

End Class
