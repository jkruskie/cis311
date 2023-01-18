Public Class Computer

    Dim strCustomerName As String
    Dim strFormFactor As String
    Dim intFormFactorPrice As Integer
    Dim strGraphicsCard As String
    Dim intGraphicsCardPrice As Integer
    Dim intMemory As Integer
    Dim intMemoryPrice As Integer
    Dim intStorage As Integer
    Dim intStoragePrice As Integer
    Dim strProcessor As String
    Dim intProcessorPrice As Integer
    Dim blnDvdRom As Boolean
    Dim intDvdRomPrice As Integer
    Dim blnSoundCard As Boolean
    Dim intSoundCardPrice As Integer
    Dim blnLiquidCooling As Boolean
    Dim intLiquidCoolingPrice As Integer

    Public Sub New()
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
        Return strCustomerName & " " & strFormFactor & " " & intFormFactorPrice & " " & strGraphicsCard & " " & intGraphicsCardPrice & " " & intMemory & " " & intMemoryPrice & " " & intStorage & " " & intStoragePrice & " " & strProcessor & " " & intProcessorPrice & " " & blnDvdRom & " " & intDvdRomPrice & " " & blnSoundCard & " " & intSoundCardPrice & " " & blnLiquidCooling & " " & intLiquidCoolingPrice
    End Function

End Class
