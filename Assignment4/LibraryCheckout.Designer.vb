<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibraryCheckout
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
        Me.components = New System.ComponentModel.Container()
        Me.lstbLibraries = New System.Windows.Forms.ListBox()
        Me.lblLibraries = New System.Windows.Forms.Label()
        Me.lstbCurrentBooks = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstbBooks = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBooksAssign = New System.Windows.Forms.Button()
        Me.btnBooksUnassign = New System.Windows.Forms.Button()
        Me.btnUnassignMedia = New System.Windows.Forms.Button()
        Me.btnAssignMedia = New System.Windows.Forms.Button()
        Me.lstbMedia = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstbCurrentMedia = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLibraryScreen = New System.Windows.Forms.Button()
        Me.errorLibraries = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errorLibraries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstbLibraries
        '
        Me.lstbLibraries.FormattingEnabled = True
        Me.lstbLibraries.Location = New System.Drawing.Point(15, 26)
        Me.lstbLibraries.Name = "lstbLibraries"
        Me.lstbLibraries.Size = New System.Drawing.Size(773, 95)
        Me.lstbLibraries.TabIndex = 3
        '
        'lblLibraries
        '
        Me.lblLibraries.AutoSize = True
        Me.lblLibraries.Location = New System.Drawing.Point(12, 9)
        Me.lblLibraries.Name = "lblLibraries"
        Me.lblLibraries.Size = New System.Drawing.Size(49, 13)
        Me.lblLibraries.TabIndex = 2
        Me.lblLibraries.Text = "Libraries:"
        '
        'lstbCurrentBooks
        '
        Me.lstbCurrentBooks.FormattingEnabled = True
        Me.lstbCurrentBooks.Location = New System.Drawing.Point(12, 165)
        Me.lstbCurrentBooks.Name = "lstbCurrentBooks"
        Me.lstbCurrentBooks.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstbCurrentBooks.Size = New System.Drawing.Size(302, 95)
        Me.lstbCurrentBooks.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Books at Current Library:"
        '
        'lstbBooks
        '
        Me.lstbBooks.FormattingEnabled = True
        Me.lstbBooks.Location = New System.Drawing.Point(486, 165)
        Me.lstbBooks.Name = "lstbBooks"
        Me.lstbBooks.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstbBooks.Size = New System.Drawing.Size(302, 95)
        Me.lstbBooks.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(483, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "All Books:"
        '
        'btnBooksAssign
        '
        Me.btnBooksAssign.Location = New System.Drawing.Point(332, 165)
        Me.btnBooksAssign.Name = "btnBooksAssign"
        Me.btnBooksAssign.Size = New System.Drawing.Size(131, 40)
        Me.btnBooksAssign.TabIndex = 8
        Me.btnBooksAssign.Text = "<--"
        Me.btnBooksAssign.UseVisualStyleBackColor = True
        '
        'btnBooksUnassign
        '
        Me.btnBooksUnassign.Location = New System.Drawing.Point(332, 220)
        Me.btnBooksUnassign.Name = "btnBooksUnassign"
        Me.btnBooksUnassign.Size = New System.Drawing.Size(131, 40)
        Me.btnBooksUnassign.TabIndex = 9
        Me.btnBooksUnassign.Text = "-->"
        Me.btnBooksUnassign.UseVisualStyleBackColor = True
        '
        'btnUnassignMedia
        '
        Me.btnUnassignMedia.Location = New System.Drawing.Point(332, 352)
        Me.btnUnassignMedia.Name = "btnUnassignMedia"
        Me.btnUnassignMedia.Size = New System.Drawing.Size(131, 40)
        Me.btnUnassignMedia.TabIndex = 15
        Me.btnUnassignMedia.Text = "-->"
        Me.btnUnassignMedia.UseVisualStyleBackColor = True
        '
        'btnAssignMedia
        '
        Me.btnAssignMedia.Location = New System.Drawing.Point(332, 297)
        Me.btnAssignMedia.Name = "btnAssignMedia"
        Me.btnAssignMedia.Size = New System.Drawing.Size(131, 40)
        Me.btnAssignMedia.TabIndex = 14
        Me.btnAssignMedia.Text = "<--"
        Me.btnAssignMedia.UseVisualStyleBackColor = True
        '
        'lstbMedia
        '
        Me.lstbMedia.FormattingEnabled = True
        Me.lstbMedia.Location = New System.Drawing.Point(486, 297)
        Me.lstbMedia.Name = "lstbMedia"
        Me.lstbMedia.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstbMedia.Size = New System.Drawing.Size(302, 95)
        Me.lstbMedia.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(483, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "All Media:"
        '
        'lstbCurrentMedia
        '
        Me.lstbCurrentMedia.FormattingEnabled = True
        Me.lstbCurrentMedia.Location = New System.Drawing.Point(12, 297)
        Me.lstbCurrentMedia.Name = "lstbCurrentMedia"
        Me.lstbCurrentMedia.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstbCurrentMedia.Size = New System.Drawing.Size(302, 95)
        Me.lstbCurrentMedia.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Media at Current Library:"
        '
        'btnLibraryScreen
        '
        Me.btnLibraryScreen.Location = New System.Drawing.Point(12, 424)
        Me.btnLibraryScreen.Name = "btnLibraryScreen"
        Me.btnLibraryScreen.Size = New System.Drawing.Size(776, 48)
        Me.btnLibraryScreen.TabIndex = 16
        Me.btnLibraryScreen.Text = "Go back to Library and Media Management "
        Me.btnLibraryScreen.UseVisualStyleBackColor = True
        '
        'errorLibraries
        '
        Me.errorLibraries.ContainerControl = Me
        '
        'LibraryCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 484)
        Me.Controls.Add(Me.btnLibraryScreen)
        Me.Controls.Add(Me.btnUnassignMedia)
        Me.Controls.Add(Me.btnAssignMedia)
        Me.Controls.Add(Me.lstbMedia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstbCurrentMedia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBooksUnassign)
        Me.Controls.Add(Me.btnBooksAssign)
        Me.Controls.Add(Me.lstbBooks)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstbCurrentBooks)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstbLibraries)
        Me.Controls.Add(Me.lblLibraries)
        Me.Name = "LibraryCheckout"
        Me.Text = "Library and Media Manager - Media Checkout"
        CType(Me.errorLibraries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstbLibraries As ListBox
    Friend WithEvents lblLibraries As Label
    Friend WithEvents lstbCurrentBooks As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstbBooks As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBooksAssign As Button
    Friend WithEvents btnBooksUnassign As Button
    Friend WithEvents btnUnassignMedia As Button
    Friend WithEvents btnAssignMedia As Button
    Friend WithEvents lstbMedia As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lstbCurrentMedia As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLibraryScreen As Button
    Friend WithEvents errorLibraries As ErrorProvider
End Class
