Public Class Inventory
    '------------------------------------------------------------
    '-                File Name : Inventory.vb                  - 
    '-                Part of Project: Inventory                -
    '------------------------------------------------------------
    '-                Written By: Justin T. Kruskie             -
    '-                Written On: January 23, 2023              -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file handles the creation of the Inventory class    -
    '- and the creation of the inventory array which holds the  -
    '- inventory items.                                         -
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
    Public Function LoadItems()
        '------------------------------------------------------------
        '-                Subprogram Name: LoadItems                -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 18, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subprogram handles the loading of the inventory     -
        '- items and returning them as an array.                    -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- objInventoryItem - An object of the InventoryItem class  -
        '- objDesktop - An object of the Desktop class              -
        '- objNotebook - An object of the Notebook class            -
        '- objTablet - An object of the Tablet class                -
        '------------------------------------------------------------
        '- Returns:                                                 -
        '- objInventory - An array of the inventory items           -
        '------------------------------------------------------------


        ' Console log
        Console.WriteLine("Loading inventory...")

        ' Create new self instance
        Dim objInventory() As Inventory

        ' Create new desktop inventory item
        Dim objDesktop As New InventoryItem
        ' Set the form factor to desktop
        objDesktop.objFormFactor = New InventoryItem.FormFactor With {
            .strType = "Desktop",
            .intPrice = 100
        }
        ' Create new graphics array
        objDesktop.arrGraphics = New InventoryItem.Graphics() {New InventoryItem.Graphics With {
            .strType = "nVidia", .intPrice = 250
        }, New InventoryItem.Graphics With {
        .strType = "ATI", .intPrice = 200
        }}
        ' Create new memory array
        objDesktop.arrMemory = New InventoryItem.Memory() {New InventoryItem.Memory With {
            .intCapacity = 8, .intPrice = 100
        }, New InventoryItem.Memory With {
            .intCapacity = 12, .intPrice = 200
        }, New InventoryItem.Memory With {
            .intCapacity = 16, .intPrice = 250
        }}
        ' Create new storage array
        objDesktop.arrStorage = New InventoryItem.Storage() {New InventoryItem.Storage With {
            .intCapacity = 1000, .intPrice = 50
        }, New InventoryItem.Storage With {
            .intCapacity = 2000, .intPrice = 100
        }, New InventoryItem.Storage With {
            .intCapacity = 4000, .intPrice = 150
        }}
        ' Create new sound card object
        objDesktop.objSoundCard = New InventoryItem.SoundCard With {
            .intPrice = 50
        }
        ' Create new liquid cooling object
        objDesktop.objLiquidCooling = New InventoryItem.LiquidCooling With {
            .intPrice = 75
        }
        ' Create new DVD ROM object
        objDesktop.objDVDRom = New InventoryItem.DVDRom With {
            .intPrice = 30
        }
        ' Create new processor array
        objDesktop.arrProcessor = New InventoryItem.Processor() {New InventoryItem.Processor With {
            .strType = "i5", .intPrice = 50
        }, New InventoryItem.Processor With {
            .strType = "i7", .intPrice = 100
        }}
        ' Create new internal camera object
        objDesktop.objInternalCamera = Nothing

        ' Add desktop to inventory
        ReDim Preserve objInventory(0)
        objInventory(0) = objDesktop

        ' Create new notebook inventory item
        Dim objNotebook As New InventoryItem
        ' Set the form factor to notebook
        objNotebook.objFormFactor = New InventoryItem.FormFactor With {
            .strType = "Notebook",
            .intPrice = 125
        }
        ' Create new graphics array
        objNotebook.arrGraphics = New InventoryItem.Graphics() {New InventoryItem.Graphics With {
            .strType = "Intel", .intPrice = 50
        }, New InventoryItem.Graphics With {
            .strType = "ATI", .intPrice = 200
        }}
        ' Create new memory array
        objNotebook.arrMemory = New InventoryItem.Memory() {New InventoryItem.Memory With {
            .intCapacity = 4, .intPrice = 50
        }, New InventoryItem.Memory With {
            .intCapacity = 8, .intPrice = 100
        }}
        ' Create new storage array
        objNotebook.arrStorage = New InventoryItem.Storage() {New InventoryItem.Storage With {
            .intCapacity = 320, .intPrice = 50
        }, New InventoryItem.Storage With {
            .intCapacity = 720, .intPrice = 75
        }}
        ' Create new sound card object
        objNotebook.objSoundCard = Nothing
        ' Create new liquid cooling object
        objNotebook.objLiquidCooling = New InventoryItem.LiquidCooling With {
            .intPrice = 75
        }
        ' Create new DVD ROM object
        objNotebook.objDVDRom = New InventoryItem.DVDRom With {
            .intPrice = 30
        }
        ' Create new processor array
        objNotebook.arrProcessor = New InventoryItem.Processor() {New InventoryItem.Processor With {
            .strType = "i5", .intPrice = 50
        }, New InventoryItem.Processor With {
            .strType = "i7", .intPrice = 100
        }}
        ' Create new internal camera object
        objNotebook.objInternalCamera = New InventoryItem.InternalCamera With {
            .intPrice = 20
        }

        ' Add notebook to inventory
        ReDim Preserve objInventory(1)
        objInventory(1) = objNotebook

        ' Create new tablet form factor
        Dim objTablet As New InventoryItem
        ' Set the form factor to tablet
        objTablet.objFormFactor = New InventoryItem.FormFactor With {
            .strType = "Tablet",
            .intPrice = 75
        }
        ' Create new graphics array
        objTablet.arrGraphics = Nothing
        ' Create new memory array
        objTablet.arrMemory = Nothing
        ' Create new storage array
        objTablet.arrStorage = New InventoryItem.Storage() {New InventoryItem.Storage With {
            .intCapacity = 8, .intPrice = 100
        }, New InventoryItem.Storage With {
            .intCapacity = 16, .intPrice = 150
        }, New InventoryItem.Storage With {
            .intCapacity = 32, .intPrice = 200
        }}
        ' Create new sound card object
        objTablet.objSoundCard = Nothing
        ' Create new liquid cooling object
        objTablet.objLiquidCooling = Nothing
        ' Create new DVD ROM object
        objTablet.objDVDRom = Nothing
        ' Create new processor array
        objTablet.arrProcessor = New InventoryItem.Processor() {New InventoryItem.Processor With {
            .strType = "ARM", .intPrice = 50
        }, New InventoryItem.Processor With {
            .strType = "Intel", .intPrice = 100
        }}
        ' Create new internal camera object
        objTablet.objInternalCamera = New InventoryItem.InternalCamera With {
            .intPrice = 20
        }

        ' Add tablet to inventory
        ReDim Preserve objInventory(2)
        objInventory(2) = objTablet

        ' Return the inventory
        Return objInventory
    End Function

End Class
