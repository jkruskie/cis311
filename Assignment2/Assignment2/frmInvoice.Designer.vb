<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
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
        Me.rtbInvoice = New System.Windows.Forms.RichTextBox()
        Me.btnChangeOrder = New System.Windows.Forms.Button()
        Me.btnProcessOrder = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtbInvoice
        '
        Me.rtbInvoice.Location = New System.Drawing.Point(12, 12)
        Me.rtbInvoice.Name = "rtbInvoice"
        Me.rtbInvoice.ReadOnly = True
        Me.rtbInvoice.Size = New System.Drawing.Size(776, 368)
        Me.rtbInvoice.TabIndex = 0
        Me.rtbInvoice.Text = ""
        '
        'btnChangeOrder
        '
        Me.btnChangeOrder.Location = New System.Drawing.Point(13, 387)
        Me.btnChangeOrder.Name = "btnChangeOrder"
        Me.btnChangeOrder.Size = New System.Drawing.Size(228, 51)
        Me.btnChangeOrder.TabIndex = 1
        Me.btnChangeOrder.Text = "Change Order"
        Me.btnChangeOrder.UseVisualStyleBackColor = True
        '
        'btnProcessOrder
        '
        Me.btnProcessOrder.Location = New System.Drawing.Point(285, 387)
        Me.btnProcessOrder.Name = "btnProcessOrder"
        Me.btnProcessOrder.Size = New System.Drawing.Size(228, 51)
        Me.btnProcessOrder.TabIndex = 2
        Me.btnProcessOrder.Text = "Process Order"
        Me.btnProcessOrder.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(560, 387)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(228, 51)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnProcessOrder)
        Me.Controls.Add(Me.btnChangeOrder)
        Me.Controls.Add(Me.rtbInvoice)
        Me.Name = "frmInvoice"
        Me.Text = "Invoice Details"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtbInvoice As RichTextBox
    Friend WithEvents btnChangeOrder As Button
    Friend WithEvents btnProcessOrder As Button
    Friend WithEvents btnExit As Button
End Class
