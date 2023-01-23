Public Class InventoryItem : Inherits Inventory
    '------------------------------------------------------------
    '-                File Name : InventoryItem.vb              - 
    '-                Part of Project: InventoryItem            -
    '------------------------------------------------------------
    '-                Written By: Justin T. Kruskie             -
    '-                Written On: January 18, 2023              -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file handles the different parts of the computer    -
    '- inventory.                                               -
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

    Public objFormFactor As FormFactor
    Public arrGraphics() As Graphics
    Public arrMemory() As Memory
    Public arrStorage() As Storage
    Public objSoundCard As SoundCard
    Public objLiquidCooling As LiquidCooling
    Public objDVDRom As DVDRom
    Public arrProcessor() As Processor
    Public objInternalCamera As InternalCamera


    Public Class FormFactor
        Public strType As String
        Public intPrice As Integer
    End Class

    Public Class Graphics
        Public strType As String
        Public intPrice As Integer
    End Class

    Public Class Memory
        Public intCapacity As Integer
        Public intPrice As Integer
    End Class

    Public Class Storage
        Public intCapacity As Integer
        Public intPrice As Integer
    End Class

    Public Class SoundCard
        Public intPrice As Integer
    End Class

    Public Class LiquidCooling
        Public intPrice As Integer
    End Class

    Public Class DVDRom
        Public intPrice As Integer
    End Class

    Public Class Processor
        Public strType As String
        Public intPrice As Integer
    End Class

    Public Class InternalCamera
        Public intPrice As Integer
    End Class

End Class
