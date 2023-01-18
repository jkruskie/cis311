Public Class frmComputerConfig

    Dim Inventory() As Inventory

    Dim strFormFactor As String

    Private Sub frmComputerConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the inventory items
        Inventory = New Inventory().LoadItems()
        ' Console log the total number of inventory items
        Console.WriteLine("Total inventory items: " & Inventory.Length)

        ' Check the desktop radio button
        radDesktop.Checked = True
        ' Set the form factor to desktop
        strFormFactor = "Desktop"
        ' Change all the labels to desktop
        DisplayDesktopInventory()
    End Sub

    ' Create new empty computer object
    Dim objComputer As New Computer

    Private Sub radDesktop_CheckedChanged(sender As Object, e As EventArgs) Handles radDesktop.CheckedChanged
        DisplayDesktopInventory()
    End Sub

    Private Sub radNotebook_CheckedChanged(sender As Object, e As EventArgs) Handles radNotebook.CheckedChanged
        ' Set the visibility of the 1st and 2nd memory radio boxes to true
        radMemory1.Visible = True
        radMemory2.Visible = True
        ' Set the visibility of the third memory radio box to dalse
        radMemory3.Visible = False
        ' Set the visibility of the 1st and 2nd storage radio boxes to true
        radStorage1.Visible = True
        radStorage2.Visible = True
        ' Set the visibility of the third storage radio box to false
        radStorage3.Visible = False
        ' Set visibility of cbSoundCarrd to false
        cbSoundCard.Visible = False
        ' Set visibility of cbLiquidCooling to true
        cbLiquidCooling.Visible = True
        ' Set visibility of cbDvdRom to true
        cbDvdRom.Visible = True
        ' Set the visibility of cbInternalCamera to true
        cbInternalCamera.Visible = True
    End Sub

    Private Sub radTablet_CheckedChanged(sender As Object, e As EventArgs) Handles radTablet.CheckedChanged
        ' Set visibility of all video card radio boxes to false
        radVideoCard1.Visible = False
        radVideoCard2.Visible = False
        ' Set the visibility of all memory radio boxes to false
        radMemory1.Visible = False
        radMemory2.Visible = False
        radMemory3.Visible = False
        ' Set the visibility of cbSoundCard to false
        cbSoundCard.Visible = False
        ' Set the visibility of cbDvdRom to false
        cbDvdRom.Visible = False
        ' Set the visibility of cbInternalCamera to true
        cbInternalCamera.Visible = True
    End Sub


    Private Sub DisplayDesktopInventory()
        ' Console log
        Console.WriteLine("Displaying desktop inventory")
        ' Adjust the visibility of all items
        ' Set the visibility of all memory radio boxes to true
        radMemory1.Visible = True
        radMemory2.Visible = True
        radMemory3.Visible = True
        ' Set the visibility of all storage radio boxes to true
        radStorage1.Visible = True
        radStorage2.Visible = True
        radStorage3.Visible = True
        ' Set the visibility of cbSoundCard to true
        cbSoundCard.Visible = True
        ' Set the visibility of cbLiquidCooling to true
        cbLiquidCooling.Visible = True
        ' Set the visibility of cbDvdRom to true
        cbDvdRom.Visible = True
        ' Set visibility of cbInternalCamera to false
        cbInternalCamera.Visible = False

        ' Set the text of all video card radio boxes
        radVideoCard1.Text = Inventory.GetValue(0).arrGraphics.GetValue(0).strType
        radVideoCard2.Text = Inventory.GetValue(0).arrGraphics.GetValue(1).strType

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

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click

    End Sub
End Class
