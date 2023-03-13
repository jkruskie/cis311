Public Class Calculator
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Validate inputs
        If ValidateInputs() Then
            ' Validation was good. Send it bro

            ' CV = EV - AC
            Dim costVariance As Double = CDbl(txtEarnedValue.Text) - CDbl(txtActualCost.Text)
            ' SV = EV - PV
            Dim scheduleVariance As Double = CDbl(txtEarnedValue.Text) - CDbl(txtPresentValue.Text)
            ' CPI = EV / AC
            Dim costPerformanceIndex As Double = CDbl(txtEarnedValue.Text) / CDbl(txtActualCost.Text)
            ' SPI = EV / PV
            Dim schedulePerformanceIndex As Double = CDbl(txtEarnedValue.Text) / CDbl(txtPresentValue.Text)
            ' EAC = BAC / CPI
            Dim estimateAtCompletion As Double = CDbl(txtBalance.Text) / costPerformanceIndex
            ' TAC = OT / SPI
            Dim timeAtCompletion As Double = CDbl(txtOriginalTime.Text) / schedulePerformanceIndex

            ' Display the results
            txtCostVariance.Text = costVariance.ToString("C")
            txtScheduleVariance.Text = scheduleVariance.ToString("C")
            txtCostPerformance.Text = costPerformanceIndex.ToString("P")
            txtSchedulePerformance.Text = schedulePerformanceIndex.ToString("P")
            txtEstimate.Text = estimateAtCompletion.ToString("C")
            txtCompletion.Text = timeAtCompletion.ToString("N") & If(radBtnMonths.Checked, " months", " years")


            ' Check if the CV is positive, negative, or zero
            If costVariance > 0 Then
                ' Positive
                ChangeBoxColor(btnCostVariance, "green")
            ElseIf costVariance < 0 Then
                ' Negative
                ChangeBoxColor(btnCostVariance, "red")
            Else
                ' Zero
                ChangeBoxColor(btnCostVariance, "yellow")
            End If

            ' Check if the SV is positive, negative, or zero
            If scheduleVariance > 0 Then
                ' Positive
                ChangeBoxColor(btnScheduleVariance, "green")
            ElseIf scheduleVariance < 0 Then
                ' Negative
                ChangeBoxColor(btnScheduleVariance, "red")
            Else
                ' Zero
                ChangeBoxColor(btnScheduleVariance, "yellow")
            End If

            ' Check if the CPI over 100%, under 100%, or 0%
            If costPerformanceIndex > 1 Then
                ' Over 100%
                ChangeBoxColor(btnCostPerformance, "green")
            ElseIf costPerformanceIndex < 1 Then
                ' Under 100%
                ChangeBoxColor(btnCostPerformance, "red")
            Else
                ' Zero
                ChangeBoxColor(btnCostPerformance, "yellow")
            End If

            ' Check if the SPI over 100%, under 100%, or 0%
            If schedulePerformanceIndex > 1 Then
                ' Over 100%
                ChangeBoxColor(btnSchedulePerformance, "green")
            ElseIf schedulePerformanceIndex < 1 Then
                ' Under 100%
                ChangeBoxColor(btnSchedulePerformance, "red")
            Else
                ' Zero
                ChangeBoxColor(btnSchedulePerformance, "yellow")
            End If

            ' If EAC > BAC then it's red
            If estimateAtCompletion > CDbl(txtBalance.Text) Then
                ' Over 100%
                ChangeBoxColor(btnEstimate, "red")
            Else
                ' Under 100%
                ChangeBoxColor(btnEstimate, "green")
            End If

            ' If TAC > OT then it's red
            If timeAtCompletion > CDbl(txtOriginalTime.Text) Then
                ' Over 100%
                ChangeBoxColor(btnCompletion, "red")
            Else
                ' Under 100%
                ChangeBoxColor(btnCompletion, "green")
            End If

        End If

    End Sub

    Private Sub ChangeBoxColor(btnCostPerformance As Button, v As String)
        ' Switch case for the color
        Select Case v
            Case "green"
                btnCostPerformance.BackColor = Color.Green
            Case "yellow"
                btnCostPerformance.BackColor = Color.Yellow
            Case "red"
                btnCostPerformance.BackColor = Color.Red
        End Select
    End Sub

    Private Function ValidateInputs()
        ' Validate the present value
        If Not IsNumeric(txtPresentValue.Text) Then
            ' Set the error provider 
            ErrorProvider1.SetError(txtPresentValue, "Present value must be numeric")
            ' Set the focus
            txtPresentValue.Focus()
            ' Reset the output fields
            ResetOutput()
            Return False
        End If

        ' Validate the present value isn't zero
        If CDbl(txtPresentValue.Text) = 0 Then
            ' Set the error provider 
            ErrorProvider1.SetError(txtPresentValue, "Present value cannot be zero")
            ' Set the focus
            txtPresentValue.Focus()
            ' Reset the output fields
            ResetOutput()
            Return False
        End If

        ' Validate the actual cost
        If Not IsNumeric(txtActualCost.Text) Then
            ' Set the error provider 
            ErrorProvider1.SetError(txtActualCost, "Actual cost must be numeric")
            ' Set the focus
            txtActualCost.Focus()
            ' Reset the output fields
            ResetOutput()
            Return False
        End If

        ' Validate the actual cost isn't zero
        If CDbl(txtActualCost.Text) = 0 Then
            ' Set the error provider 
            ErrorProvider1.SetError(txtActualCost, "Actual cost cannot be zero")
            ' Set the focus
            txtActualCost.Focus()
            ' Reset the output fields
            ResetOutput()
            Return False
        End If

        ' Validate the earned value
        If Not IsNumeric(txtEarnedValue.Text) Then
            ' Set the error provider 
            ErrorProvider1.SetError(txtEarnedValue, "Earned value must be numeric")
            ' Set the focus
            txtEarnedValue.Focus()
            ' Reset the output fields
            ResetOutput()
            Return False
        End If

        ' Validate the balance at completion
        If Not IsNumeric(txtBalance.Text) Then
            ' Set the error provider 
            ErrorProvider1.SetError(txtBalance, "Balance at completion must be numeric")
            ' Set the focus
            txtBalance.Focus()
            ' Reset the output fields
            ResetOutput()
            Return False
        End If

        ' Validate the original time
        If Not IsNumeric(txtOriginalTime.Text) Then
            ' Set the error provider 
            ErrorProvider1.SetError(txtOriginalTime, "Original time must be numeric")
            ' Set the focus
            txtOriginalTime.Focus()
            ' Reset the output fields
            ResetOutput()
            Return False
        End If

        ' Reset the error provider
        ErrorProvider1.SetError(txtPresentValue, "")
        ErrorProvider1.SetError(txtActualCost, "")
        ErrorProvider1.SetError(txtEarnedValue, "")
        ErrorProvider1.SetError(txtBalance, "")
        ErrorProvider1.SetError(txtOriginalTime, "")

        ' Return true
        Return True

    End Function

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        ' Clear the form
        For Each ctrl As Control In Me.Controls
            ' Clear all txtboxes
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            ' Reset button colors
            If TypeOf ctrl Is Button Then
                ctrl.BackColor = Color.White
            End If
        Next
        ' Clear the error provider
        ErrorProvider1.Clear()
    End Sub

    Private Sub ResetOutput()
        ' Reset the output textboxes
        txtCostVariance.Text = ""
        txtScheduleVariance.Text = ""
        txtCostPerformance.Text = ""
        txtSchedulePerformance.Text = ""
        txtEstimate.Text = ""
        txtCompletion.Text = ""
        ' Reset the button colors
        btnCostVariance.BackColor = Color.White
        btnScheduleVariance.BackColor = Color.White
        btnCostPerformance.BackColor = Color.White
        btnSchedulePerformance.BackColor = Color.White
        btnEstimate.BackColor = Color.White
        btnCompletion.BackColor = Color.White
    End Sub

    Private Sub Calculator_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (e.CloseReason = CloseReason.MdiFormClosing) Then
            Console.WriteLine("TRYING TO CLOSE MDI" & Me.Text)
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the form?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' Remove the child from the list
                Form1.ChildForms.Remove(Me)
                ' Continue close
                e.Cancel = False
                Exit Sub
                ' Close the form
                Me.Close()
            Else
                ' Cancel the close
                e.Cancel = True
                Exit Sub
                'End If
            End If
        Else
            'Console.WriteLine("TRYING TO CLOSE NOT MDI" & Me.Text)
            '' If all the textboxes are 0, close the form
            '' Else, prompt the user to confirm the close
            'If txtPresentValue.Text = "0" And
            '    txtActualCost.Text = "0" And
            '    txtEarnedValue.Text = "0" And
            '    txtBalance.Text = "0" And
            '    txtOriginalTime.Text = "0" Then
            '    ' Close the form
            '    e.Cancel = False
            'Else
            '    Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the form?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            '    ' Prompt the user to confirm the close
            '    If result = DialogResult.Yes Then
            '        ' Remove the child from the list
            '        Form1.ChildForms.Remove(Me)
            '        ' Continue close
            '        e.Cancel = False
            '        ' Close the form
            '        'Me.Close()
            '    Else
            '        ' Cancel the close
            '        e.Cancel = True
            '        Exit Sub
            '        'End If
            '    End If
            'End If
        End If
    End Sub

End Class