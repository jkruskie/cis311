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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuWindowCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuWindowTile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuWindowTileVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuWindowTileHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuWindowChildren = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFile, Me.menuWindow, Me.menuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuFile
        '
        Me.menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFileNew, Me.menuFileExit})
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(37, 20)
        Me.menuFile.Text = "File"
        '
        'menuFileNew
        '
        Me.menuFileNew.Name = "menuFileNew"
        Me.menuFileNew.Size = New System.Drawing.Size(98, 22)
        Me.menuFileNew.Text = "New"
        '
        'menuFileExit
        '
        Me.menuFileExit.Name = "menuFileExit"
        Me.menuFileExit.Size = New System.Drawing.Size(98, 22)
        Me.menuFileExit.Text = "Exit"
        '
        'menuWindow
        '
        Me.menuWindow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuWindowCascade, Me.menuWindowTile, Me.menuWindowChildren})
        Me.menuWindow.Name = "menuWindow"
        Me.menuWindow.Size = New System.Drawing.Size(63, 20)
        Me.menuWindow.Text = "Window"
        '
        'menuWindowCascade
        '
        Me.menuWindowCascade.Name = "menuWindowCascade"
        Me.menuWindowCascade.Size = New System.Drawing.Size(180, 22)
        Me.menuWindowCascade.Text = "Cascade"
        '
        'menuWindowTile
        '
        Me.menuWindowTile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuWindowTileVertical, Me.menuWindowTileHorizontal})
        Me.menuWindowTile.Name = "menuWindowTile"
        Me.menuWindowTile.Size = New System.Drawing.Size(180, 22)
        Me.menuWindowTile.Text = "Tile"
        '
        'menuWindowTileVertical
        '
        Me.menuWindowTileVertical.Name = "menuWindowTileVertical"
        Me.menuWindowTileVertical.Size = New System.Drawing.Size(129, 22)
        Me.menuWindowTileVertical.Text = "Vertical"
        '
        'menuWindowTileHorizontal
        '
        Me.menuWindowTileHorizontal.Name = "menuWindowTileHorizontal"
        Me.menuWindowTileHorizontal.Size = New System.Drawing.Size(129, 22)
        Me.menuWindowTileHorizontal.Text = "Horizontal"
        '
        'menuWindowChildren
        '
        Me.menuWindowChildren.Name = "menuWindowChildren"
        Me.menuWindowChildren.Size = New System.Drawing.Size(180, 22)
        Me.menuWindowChildren.Text = "Children"
        '
        'menuHelp
        '
        Me.menuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuHelpAbout})
        Me.menuHelp.Name = "menuHelp"
        Me.menuHelp.Size = New System.Drawing.Size(44, 20)
        Me.menuHelp.Text = "Help"
        '
        'menuHelpAbout
        '
        Me.menuHelpAbout.Name = "menuHelpAbout"
        Me.menuHelpAbout.Size = New System.Drawing.Size(107, 22)
        Me.menuHelpAbout.Text = "About"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuFile As ToolStripMenuItem
    Friend WithEvents menuWindow As ToolStripMenuItem
    Friend WithEvents menuHelp As ToolStripMenuItem
    Friend WithEvents menuHelpAbout As ToolStripMenuItem
    Friend WithEvents menuFileNew As ToolStripMenuItem
    Friend WithEvents menuFileExit As ToolStripMenuItem
    Friend WithEvents menuWindowCascade As ToolStripMenuItem
    Friend WithEvents menuWindowTile As ToolStripMenuItem
    Friend WithEvents menuWindowTileVertical As ToolStripMenuItem
    Friend WithEvents menuWindowTileHorizontal As ToolStripMenuItem
    Friend WithEvents menuWindowChildren As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
End Class
