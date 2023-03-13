<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewLibrary
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
        Me.lblIdentifier = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtIdentifier = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIdentifier
        '
        Me.lblIdentifier.AutoSize = True
        Me.lblIdentifier.Location = New System.Drawing.Point(12, 9)
        Me.lblIdentifier.Name = "lblIdentifier"
        Me.lblIdentifier.Size = New System.Drawing.Size(84, 13)
        Me.lblIdentifier.TabIndex = 0
        Me.lblIdentifier.Text = "Library Identifier:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(168, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(72, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Library Name:"
        '
        'txtIdentifier
        '
        Me.txtIdentifier.Location = New System.Drawing.Point(12, 25)
        Me.txtIdentifier.Name = "txtIdentifier"
        Me.txtIdentifier.Size = New System.Drawing.Size(100, 20)
        Me.txtIdentifier.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(171, 25)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(246, 20)
        Me.txtName.TabIndex = 3
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(12, 89)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(179, 46)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(236, 89)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(179, 46)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'AddNewLibrary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 147)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtIdentifier)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblIdentifier)
        Me.Name = "AddNewLibrary"
        Me.Text = "Add New Library"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIdentifier As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtIdentifier As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
