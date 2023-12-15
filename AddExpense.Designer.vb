<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddExpense
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
        ExpenseCButton = New Button()
        RoommateExpensePanel = New Panel()
        ExpenseRadioGroup = New GroupBox()
        NoButton = New RadioButton()
        YesButton = New RadioButton()
        SplitLabel = New Label()
        AmountTextbox = New TextBox()
        ExpenseTextbox = New TextBox()
        AmountLabel = New Label()
        ExpenseLabel = New Label()
        CancelExpense = New Button()
        ExpenseRadioGroup.SuspendLayout()
        SuspendLayout()
        ' 
        ' ExpenseCButton
        ' 
        ExpenseCButton.Location = New Point(210, 502)
        ExpenseCButton.Margin = New Padding(3, 2, 3, 2)
        ExpenseCButton.Name = "ExpenseCButton"
        ExpenseCButton.Size = New Size(75, 23)
        ExpenseCButton.TabIndex = 15
        ExpenseCButton.Text = "Create"
        ExpenseCButton.UseVisualStyleBackColor = True
        ' 
        ' RoommateExpensePanel
        ' 
        RoommateExpensePanel.Location = New Point(13, 267)
        RoommateExpensePanel.Margin = New Padding(3, 2, 3, 2)
        RoommateExpensePanel.Name = "RoommateExpensePanel"
        RoommateExpensePanel.Size = New Size(313, 92)
        RoommateExpensePanel.TabIndex = 14
        ' 
        ' ExpenseRadioGroup
        ' 
        ExpenseRadioGroup.Controls.Add(NoButton)
        ExpenseRadioGroup.Controls.Add(YesButton)
        ExpenseRadioGroup.Location = New Point(13, 215)
        ExpenseRadioGroup.Margin = New Padding(3, 2, 3, 2)
        ExpenseRadioGroup.Name = "ExpenseRadioGroup"
        ExpenseRadioGroup.Padding = New Padding(3, 2, 3, 2)
        ExpenseRadioGroup.Size = New Size(318, 36)
        ExpenseRadioGroup.TabIndex = 13
        ExpenseRadioGroup.TabStop = False
        ' 
        ' NoButton
        ' 
        NoButton.AutoSize = True
        NoButton.Location = New Point(170, 10)
        NoButton.Margin = New Padding(3, 2, 3, 2)
        NoButton.Name = "NoButton"
        NoButton.Size = New Size(41, 19)
        NoButton.TabIndex = 1
        NoButton.TabStop = True
        NoButton.Text = "No"
        NoButton.UseVisualStyleBackColor = True
        ' 
        ' YesButton
        ' 
        YesButton.AutoSize = True
        YesButton.Location = New Point(95, 10)
        YesButton.Margin = New Padding(3, 2, 3, 2)
        YesButton.Name = "YesButton"
        YesButton.Size = New Size(42, 19)
        YesButton.TabIndex = 0
        YesButton.TabStop = True
        YesButton.Text = "Yes"
        YesButton.UseVisualStyleBackColor = True
        ' 
        ' SplitLabel
        ' 
        SplitLabel.AutoSize = True
        SplitLabel.Location = New Point(96, 189)
        SplitLabel.Name = "SplitLabel"
        SplitLabel.Size = New Size(144, 15)
        SplitLabel.TabIndex = 12
        SplitLabel.Text = "Split Between Household?"
        ' 
        ' AmountTextbox
        ' 
        AmountTextbox.Location = New Point(96, 145)
        AmountTextbox.Margin = New Padding(3, 2, 3, 2)
        AmountTextbox.Name = "AmountTextbox"
        AmountTextbox.Size = New Size(204, 23)
        AmountTextbox.TabIndex = 11
        ' 
        ' ExpenseTextbox
        ' 
        ExpenseTextbox.Location = New Point(96, 98)
        ExpenseTextbox.Margin = New Padding(3, 2, 3, 2)
        ExpenseTextbox.Name = "ExpenseTextbox"
        ExpenseTextbox.Size = New Size(204, 23)
        ExpenseTextbox.TabIndex = 10
        ' 
        ' AmountLabel
        ' 
        AmountLabel.AutoSize = True
        AmountLabel.Location = New Point(35, 147)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New Size(54, 15)
        AmountLabel.TabIndex = 9
        AmountLabel.Text = "Amount:"
        ' 
        ' ExpenseLabel
        ' 
        ExpenseLabel.AutoSize = True
        ExpenseLabel.Location = New Point(35, 100)
        ExpenseLabel.Name = "ExpenseLabel"
        ExpenseLabel.Size = New Size(53, 15)
        ExpenseLabel.TabIndex = 8
        ExpenseLabel.Text = "Expense:"
        ' 
        ' CancelExpense
        ' 
        CancelExpense.Location = New Point(62, 502)
        CancelExpense.Name = "CancelExpense"
        CancelExpense.Size = New Size(75, 23)
        CancelExpense.TabIndex = 17
        CancelExpense.Text = "Cancel"
        CancelExpense.UseVisualStyleBackColor = True
        ' 
        ' AddExpense
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(218), CByte(207))
        ClientSize = New Size(349, 556)
        Controls.Add(CancelExpense)
        Controls.Add(ExpenseCButton)
        Controls.Add(RoommateExpensePanel)
        Controls.Add(ExpenseRadioGroup)
        Controls.Add(SplitLabel)
        Controls.Add(AmountTextbox)
        Controls.Add(ExpenseTextbox)
        Controls.Add(AmountLabel)
        Controls.Add(ExpenseLabel)
        Location = New Point(783, 242)
        Name = "AddExpense"
        StartPosition = FormStartPosition.Manual
        Text = "AddExpense"
        ExpenseRadioGroup.ResumeLayout(False)
        ExpenseRadioGroup.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ExpenseCButton As Button
    Friend WithEvents RoommateExpensePanel As Panel
    Friend WithEvents ExpenseRadioGroup As GroupBox
    Friend WithEvents NoButton As RadioButton
    Friend WithEvents YesButton As RadioButton
    Friend WithEvents SplitLabel As Label
    Friend WithEvents AmountTextbox As TextBox
    Friend WithEvents ExpenseTextbox As TextBox
    Friend WithEvents AmountLabel As Label
    Friend WithEvents ExpenseLabel As Label
    Friend WithEvents CancelExpense As Button
End Class
