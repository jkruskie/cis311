<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbInventoryItems = New System.Windows.Forms.GroupBox()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.gbCapacities = New System.Windows.Forms.GroupBox()
        Me.cbBytes = New System.Windows.Forms.CheckBox()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.txtProcessor = New System.Windows.Forms.TextBox()
        Me.lblProcessor = New System.Windows.Forms.Label()
        Me.txtVideo = New System.Windows.Forms.TextBox()
        Me.lblVideo = New System.Windows.Forms.Label()
        Me.txtForm = New System.Windows.Forms.TextBox()
        Me.lblForm = New System.Windows.Forms.Label()
        Me.txtRam = New System.Windows.Forms.TextBox()
        Me.lblRam = New System.Windows.Forms.Label()
        Me.txtVram = New System.Windows.Forms.TextBox()
        Me.lblVram = New System.Windows.Forms.Label()
        Me.txtHdd = New System.Windows.Forms.TextBox()
        Me.lblHdd = New System.Windows.Forms.Label()
        Me.cbWireless = New System.Windows.Forms.CheckBox()
        Me.btnMiddle = New System.Windows.Forms.Button()
        Me.gbInventoryItems.SuspendLayout()
        Me.gbCapacities.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbInventoryItems
        '
        Me.gbInventoryItems.Controls.Add(Me.cbWireless)
        Me.gbInventoryItems.Controls.Add(Me.txtHdd)
        Me.gbInventoryItems.Controls.Add(Me.lblHdd)
        Me.gbInventoryItems.Controls.Add(Me.txtVram)
        Me.gbInventoryItems.Controls.Add(Me.lblVram)
        Me.gbInventoryItems.Controls.Add(Me.txtRam)
        Me.gbInventoryItems.Controls.Add(Me.lblRam)
        Me.gbInventoryItems.Controls.Add(Me.txtForm)
        Me.gbInventoryItems.Controls.Add(Me.lblForm)
        Me.gbInventoryItems.Controls.Add(Me.txtVideo)
        Me.gbInventoryItems.Controls.Add(Me.lblVideo)
        Me.gbInventoryItems.Controls.Add(Me.txtProcessor)
        Me.gbInventoryItems.Controls.Add(Me.lblProcessor)
        Me.gbInventoryItems.Controls.Add(Me.txtManufacturer)
        Me.gbInventoryItems.Controls.Add(Me.lblManufacturer)
        Me.gbInventoryItems.Location = New System.Drawing.Point(12, 12)
        Me.gbInventoryItems.Name = "gbInventoryItems"
        Me.gbInventoryItems.Size = New System.Drawing.Size(590, 293)
        Me.gbInventoryItems.TabIndex = 0
        Me.gbInventoryItems.TabStop = False
        Me.gbInventoryItems.Text = "Item Specifications"
        '
        'lblManufacturer
        '
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.Location = New System.Drawing.Point(17, 39)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(73, 13)
        Me.lblManufacturer.TabIndex = 0
        Me.lblManufacturer.Text = "Manufacturer:"
        '
        'gbCapacities
        '
        Me.gbCapacities.Controls.Add(Me.cbBytes)
        Me.gbCapacities.Location = New System.Drawing.Point(629, 246)
        Me.gbCapacities.Name = "gbCapacities"
        Me.gbCapacities.Size = New System.Drawing.Size(82, 59)
        Me.gbCapacities.TabIndex = 1
        Me.gbCapacities.TabStop = False
        Me.gbCapacities.Text = "Capacities"
        '
        'cbBytes
        '
        Me.cbBytes.AutoSize = True
        Me.cbBytes.Location = New System.Drawing.Point(6, 25)
        Me.cbBytes.Name = "cbBytes"
        Me.cbBytes.Size = New System.Drawing.Size(52, 17)
        Me.cbBytes.TabIndex = 0
        Me.cbBytes.Text = "Bytes"
        Me.cbBytes.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(12, 326)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(170, 52)
        Me.btnLeft.TabIndex = 2
        Me.btnLeft.Text = "Save"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(432, 326)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(170, 52)
        Me.btnRight.TabIndex = 3
        Me.btnRight.Text = "Cancel"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Location = New System.Drawing.Point(96, 36)
        Me.txtManufacturer.MaxLength = 50
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.Size = New System.Drawing.Size(185, 20)
        Me.txtManufacturer.TabIndex = 1
        '
        'txtProcessor
        '
        Me.txtProcessor.Location = New System.Drawing.Point(96, 93)
        Me.txtProcessor.MaxLength = 50
        Me.txtProcessor.Name = "txtProcessor"
        Me.txtProcessor.Size = New System.Drawing.Size(185, 20)
        Me.txtProcessor.TabIndex = 3
        '
        'lblProcessor
        '
        Me.lblProcessor.AutoSize = True
        Me.lblProcessor.Location = New System.Drawing.Point(17, 96)
        Me.lblProcessor.Name = "lblProcessor"
        Me.lblProcessor.Size = New System.Drawing.Size(57, 13)
        Me.lblProcessor.TabIndex = 2
        Me.lblProcessor.Text = "Processor:"
        '
        'txtVideo
        '
        Me.txtVideo.Location = New System.Drawing.Point(96, 152)
        Me.txtVideo.MaxLength = 50
        Me.txtVideo.Name = "txtVideo"
        Me.txtVideo.Size = New System.Drawing.Size(185, 20)
        Me.txtVideo.TabIndex = 5
        '
        'lblVideo
        '
        Me.lblVideo.AutoSize = True
        Me.lblVideo.Location = New System.Drawing.Point(17, 155)
        Me.lblVideo.Name = "lblVideo"
        Me.lblVideo.Size = New System.Drawing.Size(37, 13)
        Me.lblVideo.TabIndex = 4
        Me.lblVideo.Text = "Video:"
        '
        'txtForm
        '
        Me.txtForm.Location = New System.Drawing.Point(385, 36)
        Me.txtForm.MaxLength = 50
        Me.txtForm.Name = "txtForm"
        Me.txtForm.Size = New System.Drawing.Size(185, 20)
        Me.txtForm.TabIndex = 7
        '
        'lblForm
        '
        Me.lblForm.AutoSize = True
        Me.lblForm.Location = New System.Drawing.Point(306, 39)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(33, 13)
        Me.lblForm.TabIndex = 6
        Me.lblForm.Text = "Form:"
        '
        'txtRam
        '
        Me.txtRam.Location = New System.Drawing.Point(385, 93)
        Me.txtRam.MaxLength = 50
        Me.txtRam.Name = "txtRam"
        Me.txtRam.Size = New System.Drawing.Size(185, 20)
        Me.txtRam.TabIndex = 9
        '
        'lblRam
        '
        Me.lblRam.AutoSize = True
        Me.lblRam.Location = New System.Drawing.Point(306, 96)
        Me.lblRam.Name = "lblRam"
        Me.lblRam.Size = New System.Drawing.Size(34, 13)
        Me.lblRam.TabIndex = 8
        Me.lblRam.Text = "RAM:"
        '
        'txtVram
        '
        Me.txtVram.Location = New System.Drawing.Point(385, 152)
        Me.txtVram.MaxLength = 50
        Me.txtVram.Name = "txtVram"
        Me.txtVram.Size = New System.Drawing.Size(185, 20)
        Me.txtVram.TabIndex = 11
        '
        'lblVram
        '
        Me.lblVram.AutoSize = True
        Me.lblVram.Location = New System.Drawing.Point(306, 155)
        Me.lblVram.Name = "lblVram"
        Me.lblVram.Size = New System.Drawing.Size(41, 13)
        Me.lblVram.TabIndex = 10
        Me.lblVram.Text = "VRAM:"
        '
        'txtHdd
        '
        Me.txtHdd.Location = New System.Drawing.Point(385, 216)
        Me.txtHdd.MaxLength = 50
        Me.txtHdd.Name = "txtHdd"
        Me.txtHdd.Size = New System.Drawing.Size(185, 20)
        Me.txtHdd.TabIndex = 13
        '
        'lblHdd
        '
        Me.lblHdd.AutoSize = True
        Me.lblHdd.Location = New System.Drawing.Point(306, 219)
        Me.lblHdd.Name = "lblHdd"
        Me.lblHdd.Size = New System.Drawing.Size(34, 13)
        Me.lblHdd.TabIndex = 12
        Me.lblHdd.Text = "HDD:"
        '
        'cbWireless
        '
        Me.cbWireless.AutoSize = True
        Me.cbWireless.Location = New System.Drawing.Point(80, 218)
        Me.cbWireless.Name = "cbWireless"
        Me.cbWireless.Size = New System.Drawing.Size(72, 17)
        Me.cbWireless.TabIndex = 14
        Me.cbWireless.Text = "Wireless?"
        Me.cbWireless.UseVisualStyleBackColor = True
        '
        'btnMiddle
        '
        Me.btnMiddle.Location = New System.Drawing.Point(204, 326)
        Me.btnMiddle.Name = "btnMiddle"
        Me.btnMiddle.Size = New System.Drawing.Size(211, 52)
        Me.btnMiddle.TabIndex = 4
        Me.btnMiddle.Text = "Add New Inventory Item"
        Me.btnMiddle.UseVisualStyleBackColor = True
        Me.btnMiddle.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 395)
        Me.Controls.Add(Me.btnMiddle)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.gbCapacities)
        Me.Controls.Add(Me.gbInventoryItems)
        Me.Name = "Form1"
        Me.Text = "IT Inventory Tracker"
        Me.gbInventoryItems.ResumeLayout(False)
        Me.gbInventoryItems.PerformLayout()
        Me.gbCapacities.ResumeLayout(False)
        Me.gbCapacities.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbInventoryItems As GroupBox
    Friend WithEvents gbCapacities As GroupBox
    Friend WithEvents cbBytes As CheckBox
    Friend WithEvents lblManufacturer As Label
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents cbWireless As CheckBox
    Friend WithEvents txtHdd As TextBox
    Friend WithEvents lblHdd As Label
    Friend WithEvents txtVram As TextBox
    Friend WithEvents lblVram As Label
    Friend WithEvents txtRam As TextBox
    Friend WithEvents lblRam As Label
    Friend WithEvents txtForm As TextBox
    Friend WithEvents lblForm As Label
    Friend WithEvents txtVideo As TextBox
    Friend WithEvents lblVideo As Label
    Friend WithEvents txtProcessor As TextBox
    Friend WithEvents lblProcessor As Label
    Friend WithEvents txtManufacturer As TextBox
    Friend WithEvents btnMiddle As Button
End Class
