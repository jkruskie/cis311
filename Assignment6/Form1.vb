Public Class Form1
    ' List of child forms
    Public Shared ChildForms As New List(Of Form)

    Private Sub menuHelpAbout_Click(sender As Object, e As EventArgs) Handles menuHelpAbout.Click
        ' Display the About form
        Dim frmAbout As New AboutBox1
        frmAbout.ShowDialog()
    End Sub

    Private Sub menuFileExit_Click(sender As Object, e As EventArgs) Handles menuFileExit.Click
        ' Close the form
        ' TODO: Check for unsaved data
        Me.Close()
    End Sub

    Private Sub menuFileNew_Click(sender As Object, e As EventArgs) Handles menuFileNew.Click
        ' Create new mdi child form of calculator
        Dim frmCalculator As New Calculator
        frmCalculator.MdiParent = Me
        frmCalculator.Show()
        ' Add the form to the list of child forms
        ChildForms.Add(frmCalculator)
        ' Set the title of the form
        frmCalculator.Text = "Calculator " & ChildForms.Count
    End Sub

    Private Sub menuWindowCascade_Click(sender As Object, e As EventArgs) Handles menuWindowCascade.Click
        ' Set the layout to cascade
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub menuWindowTileHorizontal_Click(sender As Object, e As EventArgs) Handles menuWindowTileHorizontal.Click
        ' Set the layout to tile horizontally
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub menuWindowTileVertical_Click(sender As Object, e As EventArgs) Handles menuWindowTileVertical.Click
        ' Set the layout to tile vertically
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub menuWindow_Click(sender As Object, e As EventArgs) Handles menuWindow.Click
        ' Display a list of child forms inside the menu
        ' Clear the menu
        menuWindowChildren.DropDownItems.Clear()

        ' Add a menu item for each child form
        For Each frm As Form In ChildForms
            Dim mi As New ToolStripMenuItem(frm.Text)
            mi.Tag = frm
            AddHandler mi.Click, AddressOf menuWindow_Click
            menuWindowChildren.DropDownItems.Add(mi)
        Next
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' If there are no child forms, close the form
        ' Else, try to close each child
        If ChildForms.Count = 0 Then
            ' Close the form
            e.Cancel = False
        Else
            ' Try to close each child using while loop
            Dim i As Integer = 0
            While i < ChildForms.Count
                ' Close the child form
                ChildForms(i).Close()
                ' If the child form is still open, cancel the close
                If ChildForms(i).IsDisposed = False Then
                    e.Cancel = True
                    Exit While
                Else
                    ' Remove the child form from the list
                    ChildForms.RemoveAt(i)
                End If
            End While
        End If
    End Sub

End Class
