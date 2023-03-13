<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibraryManagerHome
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
        Me.lblLibraries = New System.Windows.Forms.Label()
        Me.lstbLibraries = New System.Windows.Forms.ListBox()
        Me.btnAddLibrary = New System.Windows.Forms.Button()
        Me.btnDeleteLibrary = New System.Windows.Forms.Button()
        Me.btnDeleteBook = New System.Windows.Forms.Button()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.lstbBooks = New System.Windows.Forms.ListBox()
        Me.lblBooks = New System.Windows.Forms.Label()
        Me.btnDeleteMedia = New System.Windows.Forms.Button()
        Me.btnAddMedia = New System.Windows.Forms.Button()
        Me.lstbMedia = New System.Windows.Forms.ListBox()
        Me.lblMedia = New System.Windows.Forms.Label()
        Me.btnLibraryScreen = New System.Windows.Forms.Button()
        Me.errorDeleteLibrary = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorDeleteBook = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorDeleteMedia = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errorDeleteLibrary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorDeleteBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorDeleteMedia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLibraries
        '
        Me.lblLibraries.AutoSize = True
        Me.lblLibraries.Location = New System.Drawing.Point(13, 13)
        Me.lblLibraries.Name = "lblLibraries"
        Me.lblLibraries.Size = New System.Drawing.Size(49, 13)
        Me.lblLibraries.TabIndex = 0
        Me.lblLibraries.Text = "Libraries:"
        '
        'lstbLibraries
        '
        Me.lstbLibraries.FormattingEnabled = True
        Me.lstbLibraries.Location = New System.Drawing.Point(16, 30)
        Me.lstbLibraries.Name = "lstbLibraries"
        Me.lstbLibraries.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstbLibraries.Size = New System.Drawing.Size(500, 95)
        Me.lstbLibraries.TabIndex = 1
        '
        'btnAddLibrary
        '
        Me.btnAddLibrary.Location = New System.Drawing.Point(547, 30)
        Me.btnAddLibrary.Name = "btnAddLibrary"
        Me.btnAddLibrary.Size = New System.Drawing.Size(152, 40)
        Me.btnAddLibrary.TabIndex = 2
        Me.btnAddLibrary.Text = "Add Library"
        Me.btnAddLibrary.UseVisualStyleBackColor = True
        '
        'btnDeleteLibrary
        '
        Me.btnDeleteLibrary.Location = New System.Drawing.Point(547, 85)
        Me.btnDeleteLibrary.Name = "btnDeleteLibrary"
        Me.btnDeleteLibrary.Size = New System.Drawing.Size(152, 40)
        Me.btnDeleteLibrary.TabIndex = 3
        Me.btnDeleteLibrary.Text = "Delete Library"
        Me.btnDeleteLibrary.UseVisualStyleBackColor = True
        '
        'btnDeleteBook
        '
        Me.btnDeleteBook.Location = New System.Drawing.Point(547, 212)
        Me.btnDeleteBook.Name = "btnDeleteBook"
        Me.btnDeleteBook.Size = New System.Drawing.Size(152, 40)
        Me.btnDeleteBook.TabIndex = 7
        Me.btnDeleteBook.Text = "Delete Book"
        Me.btnDeleteBook.UseVisualStyleBackColor = True
        '
        'btnAddBook
        '
        Me.btnAddBook.Location = New System.Drawing.Point(547, 157)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(152, 40)
        Me.btnAddBook.TabIndex = 6
        Me.btnAddBook.Text = "Add Book"
        Me.btnAddBook.UseVisualStyleBackColor = True
        '
        'lstbBooks
        '
        Me.lstbBooks.FormattingEnabled = True
        Me.lstbBooks.Location = New System.Drawing.Point(16, 157)
        Me.lstbBooks.Name = "lstbBooks"
        Me.lstbBooks.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstbBooks.Size = New System.Drawing.Size(500, 95)
        Me.lstbBooks.TabIndex = 5
        '
        'lblBooks
        '
        Me.lblBooks.AutoSize = True
        Me.lblBooks.Location = New System.Drawing.Point(13, 140)
        Me.lblBooks.Name = "lblBooks"
        Me.lblBooks.Size = New System.Drawing.Size(40, 13)
        Me.lblBooks.TabIndex = 4
        Me.lblBooks.Text = "Books:"
        '
        'btnDeleteMedia
        '
        Me.btnDeleteMedia.Location = New System.Drawing.Point(547, 346)
        Me.btnDeleteMedia.Name = "btnDeleteMedia"
        Me.btnDeleteMedia.Size = New System.Drawing.Size(152, 40)
        Me.btnDeleteMedia.TabIndex = 11
        Me.btnDeleteMedia.Text = "Delete Media"
        Me.btnDeleteMedia.UseVisualStyleBackColor = True
        '
        'btnAddMedia
        '
        Me.btnAddMedia.Location = New System.Drawing.Point(547, 291)
        Me.btnAddMedia.Name = "btnAddMedia"
        Me.btnAddMedia.Size = New System.Drawing.Size(152, 40)
        Me.btnAddMedia.TabIndex = 10
        Me.btnAddMedia.Text = "Add Media"
        Me.btnAddMedia.UseVisualStyleBackColor = True
        '
        'lstbMedia
        '
        Me.lstbMedia.FormattingEnabled = True
        Me.lstbMedia.Location = New System.Drawing.Point(16, 291)
        Me.lstbMedia.Name = "lstbMedia"
        Me.lstbMedia.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstbMedia.Size = New System.Drawing.Size(500, 95)
        Me.lstbMedia.TabIndex = 9
        '
        'lblMedia
        '
        Me.lblMedia.AutoSize = True
        Me.lblMedia.Location = New System.Drawing.Point(13, 274)
        Me.lblMedia.Name = "lblMedia"
        Me.lblMedia.Size = New System.Drawing.Size(90, 13)
        Me.lblMedia.TabIndex = 8
        Me.lblMedia.Text = "Non-Book Media:"
        '
        'btnLibraryScreen
        '
        Me.btnLibraryScreen.Location = New System.Drawing.Point(16, 409)
        Me.btnLibraryScreen.Name = "btnLibraryScreen"
        Me.btnLibraryScreen.Size = New System.Drawing.Size(683, 48)
        Me.btnLibraryScreen.TabIndex = 12
        Me.btnLibraryScreen.Text = "Go to Library/Media Association Screen"
        Me.btnLibraryScreen.UseVisualStyleBackColor = True
        '
        'errorDeleteLibrary
        '
        Me.errorDeleteLibrary.ContainerControl = Me
        '
        'errorDeleteBook
        '
        Me.errorDeleteBook.ContainerControl = Me
        '
        'errorDeleteMedia
        '
        Me.errorDeleteMedia.ContainerControl = Me
        '
        'LibraryManagerHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 469)
        Me.Controls.Add(Me.btnLibraryScreen)
        Me.Controls.Add(Me.btnDeleteMedia)
        Me.Controls.Add(Me.btnAddMedia)
        Me.Controls.Add(Me.lstbMedia)
        Me.Controls.Add(Me.lblMedia)
        Me.Controls.Add(Me.btnDeleteBook)
        Me.Controls.Add(Me.btnAddBook)
        Me.Controls.Add(Me.lstbBooks)
        Me.Controls.Add(Me.lblBooks)
        Me.Controls.Add(Me.btnDeleteLibrary)
        Me.Controls.Add(Me.btnAddLibrary)
        Me.Controls.Add(Me.lstbLibraries)
        Me.Controls.Add(Me.lblLibraries)
        Me.Name = "LibraryManagerHome"
        Me.Text = "Library and Media Manager - Add Libraries and Media Items Here"
        CType(Me.errorDeleteLibrary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorDeleteBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorDeleteMedia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLibraries As Label
    Friend WithEvents lstbLibraries As ListBox
    Friend WithEvents btnAddLibrary As Button
    Friend WithEvents btnDeleteLibrary As Button
    Friend WithEvents btnDeleteBook As Button
    Friend WithEvents btnAddBook As Button
    Friend WithEvents lstbBooks As ListBox
    Friend WithEvents lblBooks As Label
    Friend WithEvents btnDeleteMedia As Button
    Friend WithEvents btnAddMedia As Button
    Friend WithEvents lstbMedia As ListBox
    Friend WithEvents lblMedia As Label
    Friend WithEvents btnLibraryScreen As Button
    Friend WithEvents errorDeleteLibrary As ErrorProvider
    Friend WithEvents errorDeleteBook As ErrorProvider
    Friend WithEvents errorDeleteMedia As ErrorProvider
End Class
