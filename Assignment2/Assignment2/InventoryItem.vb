Public Class InventoryItem : Inherits Inventory

    Public strFormFactor As String
    Public arrGraphics() As Graphics
    Public arrMemory() As Memory
    Public arrStorage() As Storage
    Public objSoundCard As SoundCard
    Public objLiquidCooling As LiquidCooling
    Public objDVDRom As DVDRom
    Public arrProcessor() As Processor
    Public objInternalCamera As InternalCamera

    ' To String Override
    Public Overrides Function ToString() As String
        Return strFormFactor
    End Function

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
