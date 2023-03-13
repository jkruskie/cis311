<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.lblParams = New System.Windows.Forms.Label()
        Me.lblValues = New System.Windows.Forms.Label()
        Me.lblPresentValue = New System.Windows.Forms.Label()
        Me.txtPresentValue = New System.Windows.Forms.TextBox()
        Me.txtActualCost = New System.Windows.Forms.TextBox()
        Me.lblActualCost = New System.Windows.Forms.Label()
        Me.txtEarnedValue = New System.Windows.Forms.TextBox()
        Me.lblEarnedValue = New System.Windows.Forms.Label()
        Me.txtCostVariance = New System.Windows.Forms.TextBox()
        Me.lblCostVariance = New System.Windows.Forms.Label()
        Me.btnCostVariance = New System.Windows.Forms.Button()
        Me.btnScheduleVariance = New System.Windows.Forms.Button()
        Me.txtScheduleVariance = New System.Windows.Forms.TextBox()
        Me.lblScheduleVariance = New System.Windows.Forms.Label()
        Me.btnCostPerformance = New System.Windows.Forms.Button()
        Me.txtCostPerformance = New System.Windows.Forms.TextBox()
        Me.lblCostPerformance = New System.Windows.Forms.Label()
        Me.btnSchedulePerformance = New System.Windows.Forms.Button()
        Me.txtSchedulePerformance = New System.Windows.Forms.TextBox()
        Me.lblSchedulePerformance = New System.Windows.Forms.Label()
        Me.btnEstimate = New System.Windows.Forms.Button()
        Me.txtEstimate = New System.Windows.Forms.TextBox()
        Me.lblEstimate = New System.Windows.Forms.Label()
        Me.btnCompletion = New System.Windows.Forms.Button()
        Me.txtCompletion = New System.Windows.Forms.TextBox()
        Me.lblCompletion = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.txtOriginalTime = New System.Windows.Forms.TextBox()
        Me.lblOriginalTime = New System.Windows.Forms.Label()
        Me.gboxTimeframe = New System.Windows.Forms.GroupBox()
        Me.radBtnYears = New System.Windows.Forms.RadioButton()
        Me.radBtnMonths = New System.Windows.Forms.RadioButton()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gboxTimeframe.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblParams
        '
        Me.lblParams.AutoSize = True
        Me.lblParams.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParams.Location = New System.Drawing.Point(13, 13)
        Me.lblParams.Name = "lblParams"
        Me.lblParams.Size = New System.Drawing.Size(368, 25)
        Me.lblParams.TabIndex = 0
        Me.lblParams.Text = "Enter Current Project Parameters:"
        '
        'lblValues
        '
        Me.lblValues.AutoSize = True
        Me.lblValues.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValues.Location = New System.Drawing.Point(12, 199)
        Me.lblValues.Name = "lblValues"
        Me.lblValues.Size = New System.Drawing.Size(172, 25)
        Me.lblValues.TabIndex = 1
        Me.lblValues.Text = "Project Values:"
        '
        'lblPresentValue
        '
        Me.lblPresentValue.AutoSize = True
        Me.lblPresentValue.Location = New System.Drawing.Point(18, 55)
        Me.lblPresentValue.Name = "lblPresentValue"
        Me.lblPresentValue.Size = New System.Drawing.Size(99, 13)
        Me.lblPresentValue.TabIndex = 2
        Me.lblPresentValue.Text = "Present Value (PV):"
        '
        'txtPresentValue
        '
        Me.txtPresentValue.Location = New System.Drawing.Point(123, 52)
        Me.txtPresentValue.Name = "txtPresentValue"
        Me.txtPresentValue.Size = New System.Drawing.Size(164, 20)
        Me.txtPresentValue.TabIndex = 0
        '
        'txtActualCost
        '
        Me.txtActualCost.Location = New System.Drawing.Point(123, 90)
        Me.txtActualCost.Name = "txtActualCost"
        Me.txtActualCost.Size = New System.Drawing.Size(164, 20)
        Me.txtActualCost.TabIndex = 1
        '
        'lblActualCost
        '
        Me.lblActualCost.AutoSize = True
        Me.lblActualCost.Location = New System.Drawing.Point(18, 93)
        Me.lblActualCost.Name = "lblActualCost"
        Me.lblActualCost.Size = New System.Drawing.Size(87, 13)
        Me.lblActualCost.TabIndex = 4
        Me.lblActualCost.Text = "Actual Cost (AC):"
        '
        'txtEarnedValue
        '
        Me.txtEarnedValue.Location = New System.Drawing.Point(123, 128)
        Me.txtEarnedValue.Name = "txtEarnedValue"
        Me.txtEarnedValue.Size = New System.Drawing.Size(164, 20)
        Me.txtEarnedValue.TabIndex = 2
        '
        'lblEarnedValue
        '
        Me.lblEarnedValue.AutoSize = True
        Me.lblEarnedValue.Location = New System.Drawing.Point(18, 131)
        Me.lblEarnedValue.Name = "lblEarnedValue"
        Me.lblEarnedValue.Size = New System.Drawing.Size(97, 13)
        Me.lblEarnedValue.TabIndex = 6
        Me.lblEarnedValue.Text = "Earned Value (EV):"
        '
        'txtCostVariance
        '
        Me.txtCostVariance.Location = New System.Drawing.Point(199, 246)
        Me.txtCostVariance.Name = "txtCostVariance"
        Me.txtCostVariance.ReadOnly = True
        Me.txtCostVariance.Size = New System.Drawing.Size(164, 20)
        Me.txtCostVariance.TabIndex = 7
        '
        'lblCostVariance
        '
        Me.lblCostVariance.AutoSize = True
        Me.lblCostVariance.Location = New System.Drawing.Point(18, 249)
        Me.lblCostVariance.Name = "lblCostVariance"
        Me.lblCostVariance.Size = New System.Drawing.Size(99, 13)
        Me.lblCostVariance.TabIndex = 8
        Me.lblCostVariance.Text = "Cost Variance (CV):"
        '
        'btnCostVariance
        '
        Me.btnCostVariance.Location = New System.Drawing.Point(369, 244)
        Me.btnCostVariance.Name = "btnCostVariance"
        Me.btnCostVariance.Size = New System.Drawing.Size(23, 23)
        Me.btnCostVariance.TabIndex = 10
        Me.btnCostVariance.UseVisualStyleBackColor = True
        '
        'btnScheduleVariance
        '
        Me.btnScheduleVariance.Location = New System.Drawing.Point(369, 281)
        Me.btnScheduleVariance.Name = "btnScheduleVariance"
        Me.btnScheduleVariance.Size = New System.Drawing.Size(23, 23)
        Me.btnScheduleVariance.TabIndex = 13
        Me.btnScheduleVariance.UseVisualStyleBackColor = True
        '
        'txtScheduleVariance
        '
        Me.txtScheduleVariance.Location = New System.Drawing.Point(199, 283)
        Me.txtScheduleVariance.Name = "txtScheduleVariance"
        Me.txtScheduleVariance.ReadOnly = True
        Me.txtScheduleVariance.Size = New System.Drawing.Size(164, 20)
        Me.txtScheduleVariance.TabIndex = 8
        '
        'lblScheduleVariance
        '
        Me.lblScheduleVariance.AutoSize = True
        Me.lblScheduleVariance.Location = New System.Drawing.Point(18, 286)
        Me.lblScheduleVariance.Name = "lblScheduleVariance"
        Me.lblScheduleVariance.Size = New System.Drawing.Size(123, 13)
        Me.lblScheduleVariance.TabIndex = 11
        Me.lblScheduleVariance.Text = "Schedule Variance (SV):"
        '
        'btnCostPerformance
        '
        Me.btnCostPerformance.Location = New System.Drawing.Point(369, 318)
        Me.btnCostPerformance.Name = "btnCostPerformance"
        Me.btnCostPerformance.Size = New System.Drawing.Size(23, 23)
        Me.btnCostPerformance.TabIndex = 16
        Me.btnCostPerformance.UseVisualStyleBackColor = True
        '
        'txtCostPerformance
        '
        Me.txtCostPerformance.Location = New System.Drawing.Point(199, 320)
        Me.txtCostPerformance.Name = "txtCostPerformance"
        Me.txtCostPerformance.ReadOnly = True
        Me.txtCostPerformance.Size = New System.Drawing.Size(164, 20)
        Me.txtCostPerformance.TabIndex = 9
        '
        'lblCostPerformance
        '
        Me.lblCostPerformance.AutoSize = True
        Me.lblCostPerformance.Location = New System.Drawing.Point(18, 323)
        Me.lblCostPerformance.Name = "lblCostPerformance"
        Me.lblCostPerformance.Size = New System.Drawing.Size(149, 13)
        Me.lblCostPerformance.TabIndex = 14
        Me.lblCostPerformance.Text = "Cost Performance Index (CPI):"
        '
        'btnSchedulePerformance
        '
        Me.btnSchedulePerformance.Location = New System.Drawing.Point(369, 355)
        Me.btnSchedulePerformance.Name = "btnSchedulePerformance"
        Me.btnSchedulePerformance.Size = New System.Drawing.Size(23, 23)
        Me.btnSchedulePerformance.TabIndex = 19
        Me.btnSchedulePerformance.UseVisualStyleBackColor = True
        '
        'txtSchedulePerformance
        '
        Me.txtSchedulePerformance.Location = New System.Drawing.Point(199, 357)
        Me.txtSchedulePerformance.Name = "txtSchedulePerformance"
        Me.txtSchedulePerformance.ReadOnly = True
        Me.txtSchedulePerformance.Size = New System.Drawing.Size(164, 20)
        Me.txtSchedulePerformance.TabIndex = 10
        '
        'lblSchedulePerformance
        '
        Me.lblSchedulePerformance.AutoSize = True
        Me.lblSchedulePerformance.Location = New System.Drawing.Point(18, 360)
        Me.lblSchedulePerformance.Name = "lblSchedulePerformance"
        Me.lblSchedulePerformance.Size = New System.Drawing.Size(173, 13)
        Me.lblSchedulePerformance.TabIndex = 17
        Me.lblSchedulePerformance.Text = "Schedule Performance Index (SPI):"
        '
        'btnEstimate
        '
        Me.btnEstimate.Location = New System.Drawing.Point(710, 276)
        Me.btnEstimate.Name = "btnEstimate"
        Me.btnEstimate.Size = New System.Drawing.Size(23, 23)
        Me.btnEstimate.TabIndex = 22
        Me.btnEstimate.UseVisualStyleBackColor = True
        '
        'txtEstimate
        '
        Me.txtEstimate.Location = New System.Drawing.Point(540, 278)
        Me.txtEstimate.Name = "txtEstimate"
        Me.txtEstimate.ReadOnly = True
        Me.txtEstimate.Size = New System.Drawing.Size(164, 20)
        Me.txtEstimate.TabIndex = 11
        '
        'lblEstimate
        '
        Me.lblEstimate.AutoSize = True
        Me.lblEstimate.Location = New System.Drawing.Point(435, 281)
        Me.lblEstimate.Name = "lblEstimate"
        Me.lblEstimate.Size = New System.Drawing.Size(99, 13)
        Me.lblEstimate.TabIndex = 20
        Me.lblEstimate.Text = "Present Value (PV):"
        '
        'btnCompletion
        '
        Me.btnCompletion.Location = New System.Drawing.Point(710, 314)
        Me.btnCompletion.Name = "btnCompletion"
        Me.btnCompletion.Size = New System.Drawing.Size(23, 23)
        Me.btnCompletion.TabIndex = 25
        Me.btnCompletion.UseVisualStyleBackColor = True
        '
        'txtCompletion
        '
        Me.txtCompletion.Location = New System.Drawing.Point(540, 316)
        Me.txtCompletion.Name = "txtCompletion"
        Me.txtCompletion.ReadOnly = True
        Me.txtCompletion.Size = New System.Drawing.Size(164, 20)
        Me.txtCompletion.TabIndex = 12
        '
        'lblCompletion
        '
        Me.lblCompletion.AutoSize = True
        Me.lblCompletion.Location = New System.Drawing.Point(435, 319)
        Me.lblCompletion.Name = "lblCompletion"
        Me.lblCompletion.Size = New System.Drawing.Size(99, 13)
        Me.lblCompletion.TabIndex = 23
        Me.lblCompletion.Text = "Present Value (PV):"
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(461, 49)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(164, 20)
        Me.txtBalance.TabIndex = 3
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(307, 52)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(146, 13)
        Me.lblBalance.TabIndex = 26
        Me.lblBalance.Text = "Balance at Completion (BAC):"
        '
        'txtOriginalTime
        '
        Me.txtOriginalTime.Location = New System.Drawing.Point(461, 88)
        Me.txtOriginalTime.Name = "txtOriginalTime"
        Me.txtOriginalTime.Size = New System.Drawing.Size(164, 20)
        Me.txtOriginalTime.TabIndex = 4
        '
        'lblOriginalTime
        '
        Me.lblOriginalTime.AutoSize = True
        Me.lblOriginalTime.Location = New System.Drawing.Point(307, 91)
        Me.lblOriginalTime.Name = "lblOriginalTime"
        Me.lblOriginalTime.Size = New System.Drawing.Size(95, 13)
        Me.lblOriginalTime.TabIndex = 28
        Me.lblOriginalTime.Text = "Original Time (OT):"
        '
        'gboxTimeframe
        '
        Me.gboxTimeframe.Controls.Add(Me.radBtnYears)
        Me.gboxTimeframe.Controls.Add(Me.radBtnMonths)
        Me.gboxTimeframe.Location = New System.Drawing.Point(328, 128)
        Me.gboxTimeframe.Name = "gboxTimeframe"
        Me.gboxTimeframe.Size = New System.Drawing.Size(266, 70)
        Me.gboxTimeframe.TabIndex = 30
        Me.gboxTimeframe.TabStop = False
        Me.gboxTimeframe.Text = "Timeframe:"
        '
        'radBtnYears
        '
        Me.radBtnYears.AutoSize = True
        Me.radBtnYears.Location = New System.Drawing.Point(155, 32)
        Me.radBtnYears.Name = "radBtnYears"
        Me.radBtnYears.Size = New System.Drawing.Size(52, 17)
        Me.radBtnYears.TabIndex = 1
        Me.radBtnYears.Text = "Years"
        Me.radBtnYears.UseVisualStyleBackColor = True
        '
        'radBtnMonths
        '
        Me.radBtnMonths.AutoSize = True
        Me.radBtnMonths.Checked = True
        Me.radBtnMonths.Location = New System.Drawing.Point(46, 32)
        Me.radBtnMonths.Name = "radBtnMonths"
        Me.radBtnMonths.Size = New System.Drawing.Size(60, 17)
        Me.radBtnMonths.TabIndex = 0
        Me.radBtnMonths.TabStop = True
        Me.radBtnMonths.Text = "Months"
        Me.radBtnMonths.UseVisualStyleBackColor = True
        '
        'btnClearForm
        '
        Me.btnClearForm.Location = New System.Drawing.Point(647, 113)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(174, 43)
        Me.btnClearForm.TabIndex = 6
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(647, 52)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(174, 43)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate Values"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 398)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.gboxTimeframe)
        Me.Controls.Add(Me.txtOriginalTime)
        Me.Controls.Add(Me.lblOriginalTime)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.btnCompletion)
        Me.Controls.Add(Me.txtCompletion)
        Me.Controls.Add(Me.lblCompletion)
        Me.Controls.Add(Me.btnEstimate)
        Me.Controls.Add(Me.txtEstimate)
        Me.Controls.Add(Me.lblEstimate)
        Me.Controls.Add(Me.btnSchedulePerformance)
        Me.Controls.Add(Me.txtSchedulePerformance)
        Me.Controls.Add(Me.lblSchedulePerformance)
        Me.Controls.Add(Me.btnCostPerformance)
        Me.Controls.Add(Me.txtCostPerformance)
        Me.Controls.Add(Me.lblCostPerformance)
        Me.Controls.Add(Me.btnScheduleVariance)
        Me.Controls.Add(Me.txtScheduleVariance)
        Me.Controls.Add(Me.lblScheduleVariance)
        Me.Controls.Add(Me.btnCostVariance)
        Me.Controls.Add(Me.txtCostVariance)
        Me.Controls.Add(Me.lblCostVariance)
        Me.Controls.Add(Me.txtEarnedValue)
        Me.Controls.Add(Me.lblEarnedValue)
        Me.Controls.Add(Me.txtActualCost)
        Me.Controls.Add(Me.lblActualCost)
        Me.Controls.Add(Me.txtPresentValue)
        Me.Controls.Add(Me.lblPresentValue)
        Me.Controls.Add(Me.lblValues)
        Me.Controls.Add(Me.lblParams)
        Me.Name = "Calculator"
        Me.Text = "0"
        Me.gboxTimeframe.ResumeLayout(False)
        Me.gboxTimeframe.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblParams As Label
    Friend WithEvents lblValues As Label
    Friend WithEvents lblPresentValue As Label
    Friend WithEvents txtPresentValue As TextBox
    Friend WithEvents txtActualCost As TextBox
    Friend WithEvents lblActualCost As Label
    Friend WithEvents txtEarnedValue As TextBox
    Friend WithEvents lblEarnedValue As Label
    Friend WithEvents txtCostVariance As TextBox
    Friend WithEvents lblCostVariance As Label
    Friend WithEvents btnCostVariance As Button
    Friend WithEvents btnScheduleVariance As Button
    Friend WithEvents txtScheduleVariance As TextBox
    Friend WithEvents lblScheduleVariance As Label
    Friend WithEvents btnCostPerformance As Button
    Friend WithEvents txtCostPerformance As TextBox
    Friend WithEvents lblCostPerformance As Label
    Friend WithEvents btnSchedulePerformance As Button
    Friend WithEvents txtSchedulePerformance As TextBox
    Friend WithEvents lblSchedulePerformance As Label
    Friend WithEvents btnEstimate As Button
    Friend WithEvents txtEstimate As TextBox
    Friend WithEvents lblEstimate As Label
    Friend WithEvents btnCompletion As Button
    Friend WithEvents txtCompletion As TextBox
    Friend WithEvents lblCompletion As Label
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents lblBalance As Label
    Friend WithEvents txtOriginalTime As TextBox
    Friend WithEvents lblOriginalTime As Label
    Friend WithEvents gboxTimeframe As GroupBox
    Friend WithEvents radBtnYears As RadioButton
    Friend WithEvents radBtnMonths As RadioButton
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
