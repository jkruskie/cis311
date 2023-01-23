<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmComputerConfig
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComputerConfig))
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.radDesktop = New System.Windows.Forms.RadioButton()
        Me.radNotebook = New System.Windows.Forms.RadioButton()
        Me.radTablet = New System.Windows.Forms.RadioButton()
        Me.grbFormFactor = New System.Windows.Forms.GroupBox()
        Me.grbVideoCard = New System.Windows.Forms.GroupBox()
        Me.radVideoCard2 = New System.Windows.Forms.RadioButton()
        Me.radVideoCard1 = New System.Windows.Forms.RadioButton()
        Me.grbMemory = New System.Windows.Forms.GroupBox()
        Me.radMemory3 = New System.Windows.Forms.RadioButton()
        Me.radMemory2 = New System.Windows.Forms.RadioButton()
        Me.radMemory1 = New System.Windows.Forms.RadioButton()
        Me.grbStorage = New System.Windows.Forms.GroupBox()
        Me.radStorage3 = New System.Windows.Forms.RadioButton()
        Me.radStorage2 = New System.Windows.Forms.RadioButton()
        Me.radStorage1 = New System.Windows.Forms.RadioButton()
        Me.grbProcessor = New System.Windows.Forms.GroupBox()
        Me.radProcessor2 = New System.Windows.Forms.RadioButton()
        Me.radProcessor1 = New System.Windows.Forms.RadioButton()
        Me.grbDvdRom = New System.Windows.Forms.GroupBox()
        Me.cbDvdRom = New System.Windows.Forms.CheckBox()
        Me.grbSoundCard = New System.Windows.Forms.GroupBox()
        Me.cbSoundCard = New System.Windows.Forms.CheckBox()
        Me.grbLiquidCooling = New System.Windows.Forms.GroupBox()
        Me.cbLiquidCooling = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.grbInternalCamera = New System.Windows.Forms.GroupBox()
        Me.cbInternalCamera = New System.Windows.Forms.CheckBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.grbFormFactor.SuspendLayout()
        Me.grbVideoCard.SuspendLayout()
        Me.grbMemory.SuspendLayout()
        Me.grbStorage.SuspendLayout()
        Me.grbProcessor.SuspendLayout()
        Me.grbDvdRom.SuspendLayout()
        Me.grbSoundCard.SuspendLayout()
        Me.grbLiquidCooling.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbInternalCamera.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(13, 13)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(85, 13)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "Customer Name:"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerName.Location = New System.Drawing.Point(104, 11)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(214, 20)
        Me.txtCustomerName.TabIndex = 0
        '
        'radDesktop
        '
        Me.radDesktop.AutoSize = True
        Me.radDesktop.Location = New System.Drawing.Point(45, 19)
        Me.radDesktop.Name = "radDesktop"
        Me.radDesktop.Size = New System.Drawing.Size(65, 17)
        Me.radDesktop.TabIndex = 0
        Me.radDesktop.Text = "Desktop"
        Me.radDesktop.UseVisualStyleBackColor = True
        '
        'radNotebook
        '
        Me.radNotebook.AutoSize = True
        Me.radNotebook.Location = New System.Drawing.Point(275, 19)
        Me.radNotebook.Name = "radNotebook"
        Me.radNotebook.Size = New System.Drawing.Size(72, 17)
        Me.radNotebook.TabIndex = 1
        Me.radNotebook.Text = "Notebook"
        Me.radNotebook.UseVisualStyleBackColor = True
        '
        'radTablet
        '
        Me.radTablet.AutoSize = True
        Me.radTablet.Location = New System.Drawing.Point(516, 19)
        Me.radTablet.Name = "radTablet"
        Me.radTablet.Size = New System.Drawing.Size(55, 17)
        Me.radTablet.TabIndex = 3
        Me.radTablet.Text = "Tablet"
        Me.radTablet.UseVisualStyleBackColor = True
        '
        'grbFormFactor
        '
        Me.grbFormFactor.Controls.Add(Me.radTablet)
        Me.grbFormFactor.Controls.Add(Me.radNotebook)
        Me.grbFormFactor.Controls.Add(Me.radDesktop)
        Me.grbFormFactor.Location = New System.Drawing.Point(13, 43)
        Me.grbFormFactor.Name = "grbFormFactor"
        Me.grbFormFactor.Size = New System.Drawing.Size(625, 46)
        Me.grbFormFactor.TabIndex = 1
        Me.grbFormFactor.TabStop = False
        Me.grbFormFactor.Text = "Form Factor"
        '
        'grbVideoCard
        '
        Me.grbVideoCard.Controls.Add(Me.radVideoCard2)
        Me.grbVideoCard.Controls.Add(Me.radVideoCard1)
        Me.grbVideoCard.Location = New System.Drawing.Point(13, 110)
        Me.grbVideoCard.Name = "grbVideoCard"
        Me.grbVideoCard.Size = New System.Drawing.Size(269, 46)
        Me.grbVideoCard.TabIndex = 2
        Me.grbVideoCard.TabStop = False
        Me.grbVideoCard.Text = "Video Card"
        '
        'radVideoCard2
        '
        Me.radVideoCard2.AutoSize = True
        Me.radVideoCard2.Location = New System.Drawing.Point(160, 19)
        Me.radVideoCard2.Name = "radVideoCard2"
        Me.radVideoCard2.Size = New System.Drawing.Size(101, 17)
        Me.radVideoCard2.TabIndex = 1
        Me.radVideoCard2.TabStop = True
        Me.radVideoCard2.Text = "Graphics Card 2"
        Me.radVideoCard2.UseVisualStyleBackColor = True
        '
        'radVideoCard1
        '
        Me.radVideoCard1.AutoSize = True
        Me.radVideoCard1.Location = New System.Drawing.Point(18, 19)
        Me.radVideoCard1.Name = "radVideoCard1"
        Me.radVideoCard1.Size = New System.Drawing.Size(101, 17)
        Me.radVideoCard1.TabIndex = 0
        Me.radVideoCard1.TabStop = True
        Me.radVideoCard1.Text = "Graphics Card 1"
        Me.radVideoCard1.UseVisualStyleBackColor = True
        '
        'grbMemory
        '
        Me.grbMemory.Controls.Add(Me.radMemory3)
        Me.grbMemory.Controls.Add(Me.radMemory2)
        Me.grbMemory.Controls.Add(Me.radMemory1)
        Me.grbMemory.Location = New System.Drawing.Point(13, 162)
        Me.grbMemory.Name = "grbMemory"
        Me.grbMemory.Size = New System.Drawing.Size(269, 46)
        Me.grbMemory.TabIndex = 3
        Me.grbMemory.TabStop = False
        Me.grbMemory.Text = "Memory"
        '
        'radMemory3
        '
        Me.radMemory3.AutoSize = True
        Me.radMemory3.Location = New System.Drawing.Point(187, 19)
        Me.radMemory3.Name = "radMemory3"
        Me.radMemory3.Size = New System.Drawing.Size(71, 17)
        Me.radMemory3.TabIndex = 2
        Me.radMemory3.TabStop = True
        Me.radMemory3.Text = "Memory 3"
        Me.radMemory3.UseVisualStyleBackColor = True
        '
        'radMemory2
        '
        Me.radMemory2.AutoSize = True
        Me.radMemory2.Location = New System.Drawing.Point(101, 19)
        Me.radMemory2.Name = "radMemory2"
        Me.radMemory2.Size = New System.Drawing.Size(71, 17)
        Me.radMemory2.TabIndex = 1
        Me.radMemory2.TabStop = True
        Me.radMemory2.Text = "Memory 2"
        Me.radMemory2.UseVisualStyleBackColor = True
        '
        'radMemory1
        '
        Me.radMemory1.AutoSize = True
        Me.radMemory1.Location = New System.Drawing.Point(15, 19)
        Me.radMemory1.Name = "radMemory1"
        Me.radMemory1.Size = New System.Drawing.Size(71, 17)
        Me.radMemory1.TabIndex = 0
        Me.radMemory1.TabStop = True
        Me.radMemory1.Text = "Memory 1"
        Me.radMemory1.UseVisualStyleBackColor = True
        '
        'grbStorage
        '
        Me.grbStorage.Controls.Add(Me.radStorage3)
        Me.grbStorage.Controls.Add(Me.radStorage2)
        Me.grbStorage.Controls.Add(Me.radStorage1)
        Me.grbStorage.Location = New System.Drawing.Point(13, 214)
        Me.grbStorage.Name = "grbStorage"
        Me.grbStorage.Size = New System.Drawing.Size(269, 46)
        Me.grbStorage.TabIndex = 4
        Me.grbStorage.TabStop = False
        Me.grbStorage.Text = "Storage"
        '
        'radStorage3
        '
        Me.radStorage3.AutoSize = True
        Me.radStorage3.Location = New System.Drawing.Point(187, 19)
        Me.radStorage3.Name = "radStorage3"
        Me.radStorage3.Size = New System.Drawing.Size(71, 17)
        Me.radStorage3.TabIndex = 2
        Me.radStorage3.TabStop = True
        Me.radStorage3.Text = "Storage 3"
        Me.radStorage3.UseVisualStyleBackColor = True
        '
        'radStorage2
        '
        Me.radStorage2.AutoSize = True
        Me.radStorage2.Location = New System.Drawing.Point(101, 19)
        Me.radStorage2.Name = "radStorage2"
        Me.radStorage2.Size = New System.Drawing.Size(71, 17)
        Me.radStorage2.TabIndex = 1
        Me.radStorage2.TabStop = True
        Me.radStorage2.Text = "Storage 2"
        Me.radStorage2.UseVisualStyleBackColor = True
        '
        'radStorage1
        '
        Me.radStorage1.AutoSize = True
        Me.radStorage1.Location = New System.Drawing.Point(15, 19)
        Me.radStorage1.Name = "radStorage1"
        Me.radStorage1.Size = New System.Drawing.Size(71, 17)
        Me.radStorage1.TabIndex = 0
        Me.radStorage1.TabStop = True
        Me.radStorage1.Text = "Storage 1"
        Me.radStorage1.UseVisualStyleBackColor = True
        '
        'grbProcessor
        '
        Me.grbProcessor.Controls.Add(Me.radProcessor2)
        Me.grbProcessor.Controls.Add(Me.radProcessor1)
        Me.grbProcessor.Location = New System.Drawing.Point(13, 266)
        Me.grbProcessor.Name = "grbProcessor"
        Me.grbProcessor.Size = New System.Drawing.Size(269, 46)
        Me.grbProcessor.TabIndex = 5
        Me.grbProcessor.TabStop = False
        Me.grbProcessor.Text = "Processor"
        '
        'radProcessor2
        '
        Me.radProcessor2.AutoSize = True
        Me.radProcessor2.Location = New System.Drawing.Point(160, 19)
        Me.radProcessor2.Name = "radProcessor2"
        Me.radProcessor2.Size = New System.Drawing.Size(81, 17)
        Me.radProcessor2.TabIndex = 1
        Me.radProcessor2.TabStop = True
        Me.radProcessor2.Text = "Processor 2"
        Me.radProcessor2.UseVisualStyleBackColor = True
        '
        'radProcessor1
        '
        Me.radProcessor1.AutoSize = True
        Me.radProcessor1.Location = New System.Drawing.Point(18, 19)
        Me.radProcessor1.Name = "radProcessor1"
        Me.radProcessor1.Size = New System.Drawing.Size(81, 17)
        Me.radProcessor1.TabIndex = 0
        Me.radProcessor1.TabStop = True
        Me.radProcessor1.Text = "Processor 1"
        Me.radProcessor1.UseVisualStyleBackColor = True
        '
        'grbDvdRom
        '
        Me.grbDvdRom.Controls.Add(Me.cbDvdRom)
        Me.grbDvdRom.Location = New System.Drawing.Point(13, 319)
        Me.grbDvdRom.Name = "grbDvdRom"
        Me.grbDvdRom.Size = New System.Drawing.Size(119, 48)
        Me.grbDvdRom.TabIndex = 6
        Me.grbDvdRom.TabStop = False
        Me.grbDvdRom.Text = "DVD-ROM"
        '
        'cbDvdRom
        '
        Me.cbDvdRom.AutoSize = True
        Me.cbDvdRom.Location = New System.Drawing.Point(35, 19)
        Me.cbDvdRom.Name = "cbDvdRom"
        Me.cbDvdRom.Size = New System.Drawing.Size(50, 17)
        Me.cbDvdRom.TabIndex = 0
        Me.cbDvdRom.Text = "Yes?"
        Me.cbDvdRom.UseVisualStyleBackColor = True
        '
        'grbSoundCard
        '
        Me.grbSoundCard.Controls.Add(Me.cbSoundCard)
        Me.grbSoundCard.Location = New System.Drawing.Point(163, 319)
        Me.grbSoundCard.Name = "grbSoundCard"
        Me.grbSoundCard.Size = New System.Drawing.Size(119, 48)
        Me.grbSoundCard.TabIndex = 7
        Me.grbSoundCard.TabStop = False
        Me.grbSoundCard.Text = "Sound Card"
        '
        'cbSoundCard
        '
        Me.cbSoundCard.AutoSize = True
        Me.cbSoundCard.Location = New System.Drawing.Point(37, 19)
        Me.cbSoundCard.Name = "cbSoundCard"
        Me.cbSoundCard.Size = New System.Drawing.Size(50, 17)
        Me.cbSoundCard.TabIndex = 1
        Me.cbSoundCard.Text = "Yes?"
        Me.cbSoundCard.UseVisualStyleBackColor = True
        '
        'grbLiquidCooling
        '
        Me.grbLiquidCooling.Controls.Add(Me.cbLiquidCooling)
        Me.grbLiquidCooling.Location = New System.Drawing.Point(13, 373)
        Me.grbLiquidCooling.Name = "grbLiquidCooling"
        Me.grbLiquidCooling.Size = New System.Drawing.Size(119, 48)
        Me.grbLiquidCooling.TabIndex = 8
        Me.grbLiquidCooling.TabStop = False
        Me.grbLiquidCooling.Text = "Liquid Cooling"
        '
        'cbLiquidCooling
        '
        Me.cbLiquidCooling.AutoSize = True
        Me.cbLiquidCooling.Location = New System.Drawing.Point(35, 19)
        Me.cbLiquidCooling.Name = "cbLiquidCooling"
        Me.cbLiquidCooling.Size = New System.Drawing.Size(50, 17)
        Me.cbLiquidCooling.TabIndex = 13
        Me.cbLiquidCooling.Text = "Yes?"
        Me.cbLiquidCooling.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(288, 129)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(354, 215)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(332, 373)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(306, 48)
        Me.btnPlaceOrder.TabIndex = 11
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'grbInternalCamera
        '
        Me.grbInternalCamera.Controls.Add(Me.cbInternalCamera)
        Me.grbInternalCamera.Location = New System.Drawing.Point(163, 373)
        Me.grbInternalCamera.Name = "grbInternalCamera"
        Me.grbInternalCamera.Size = New System.Drawing.Size(119, 48)
        Me.grbInternalCamera.TabIndex = 9
        Me.grbInternalCamera.TabStop = False
        Me.grbInternalCamera.Text = "Internal Camera"
        '
        'cbInternalCamera
        '
        Me.cbInternalCamera.AutoSize = True
        Me.cbInternalCamera.Location = New System.Drawing.Point(35, 19)
        Me.cbInternalCamera.Name = "cbInternalCamera"
        Me.cbInternalCamera.Size = New System.Drawing.Size(50, 17)
        Me.cbInternalCamera.TabIndex = 13
        Me.cbInternalCamera.Text = "Yes?"
        Me.cbInternalCamera.UseVisualStyleBackColor = True
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(553, 17)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(49, 13)
        Me.lblQuantity.TabIndex = 15
        Me.lblQuantity.Text = "Quantity:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(600, 17)
        Me.txtQuantity.MaxLength = 3
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(42, 20)
        Me.txtQuantity.TabIndex = 10
        '
        'frmComputerConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 450)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.grbInternalCamera)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grbLiquidCooling)
        Me.Controls.Add(Me.grbSoundCard)
        Me.Controls.Add(Me.grbDvdRom)
        Me.Controls.Add(Me.grbProcessor)
        Me.Controls.Add(Me.grbStorage)
        Me.Controls.Add(Me.grbMemory)
        Me.Controls.Add(Me.grbVideoCard)
        Me.Controls.Add(Me.grbFormFactor)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Name = "frmComputerConfig"
        Me.Text = "3"
        Me.grbFormFactor.ResumeLayout(False)
        Me.grbFormFactor.PerformLayout()
        Me.grbVideoCard.ResumeLayout(False)
        Me.grbVideoCard.PerformLayout()
        Me.grbMemory.ResumeLayout(False)
        Me.grbMemory.PerformLayout()
        Me.grbStorage.ResumeLayout(False)
        Me.grbStorage.PerformLayout()
        Me.grbProcessor.ResumeLayout(False)
        Me.grbProcessor.PerformLayout()
        Me.grbDvdRom.ResumeLayout(False)
        Me.grbDvdRom.PerformLayout()
        Me.grbSoundCard.ResumeLayout(False)
        Me.grbSoundCard.PerformLayout()
        Me.grbLiquidCooling.ResumeLayout(False)
        Me.grbLiquidCooling.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbInternalCamera.ResumeLayout(False)
        Me.grbInternalCamera.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCustomerName As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents radDesktop As RadioButton
    Friend WithEvents radNotebook As RadioButton
    Friend WithEvents radTablet As RadioButton
    Friend WithEvents grbFormFactor As GroupBox
    Friend WithEvents grbVideoCard As GroupBox
    Friend WithEvents radVideoCard2 As RadioButton
    Friend WithEvents radVideoCard1 As RadioButton
    Friend WithEvents grbMemory As GroupBox
    Friend WithEvents radMemory3 As RadioButton
    Friend WithEvents radMemory2 As RadioButton
    Friend WithEvents radMemory1 As RadioButton
    Friend WithEvents grbStorage As GroupBox
    Friend WithEvents radStorage3 As RadioButton
    Friend WithEvents radStorage2 As RadioButton
    Friend WithEvents radStorage1 As RadioButton
    Friend WithEvents grbProcessor As GroupBox
    Friend WithEvents radProcessor2 As RadioButton
    Friend WithEvents radProcessor1 As RadioButton
    Friend WithEvents grbDvdRom As GroupBox
    Friend WithEvents grbSoundCard As GroupBox
    Friend WithEvents grbLiquidCooling As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents cbDvdRom As CheckBox
    Friend WithEvents cbSoundCard As CheckBox
    Friend WithEvents cbLiquidCooling As CheckBox
    Friend WithEvents grbInternalCamera As GroupBox
    Friend WithEvents cbInternalCamera As CheckBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtQuantity As TextBox
End Class
