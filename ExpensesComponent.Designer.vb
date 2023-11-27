<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpensesComponent
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        ExpenseLabel = New Label()
        AmountLabel = New Label()
        ExpenseTextbox = New TextBox()
        AmountTextbox = New TextBox()
        SplitLabel = New Label()
        ExpenseRadioGroup = New GroupBox()
        NoButton = New RadioButton()
        YesButton = New RadioButton()
        RoommateExpensePanel = New Panel()
        ExpenseCButton = New Button()
        ExpenseRadioGroup.SuspendLayout()
        SuspendLayout()
        ' 
        ' ExpenseLabel
        ' 
        ExpenseLabel.AutoSize = True
        ExpenseLabel.Location = New Point(11, 28)
        ExpenseLabel.Name = "ExpenseLabel"
        ExpenseLabel.Size = New Size(66, 20)
        ExpenseLabel.TabIndex = 0
        ExpenseLabel.Text = "Expense:"
        ' 
        ' AmountLabel
        ' 
        AmountLabel.AutoSize = True
        AmountLabel.Location = New Point(11, 79)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New Size(65, 20)
        AmountLabel.TabIndex = 1
        AmountLabel.Text = "Amount:"
        ' 
        ' ExpenseTextbox
        ' 
        ExpenseTextbox.Location = New Point(81, 25)
        ExpenseTextbox.Name = "ExpenseTextbox"
        ExpenseTextbox.Size = New Size(279, 27)
        ExpenseTextbox.TabIndex = 2
        ' 
        ' AmountTextbox
        ' 
        AmountTextbox.Location = New Point(81, 76)
        AmountTextbox.Name = "AmountTextbox"
        AmountTextbox.Size = New Size(279, 27)
        AmountTextbox.TabIndex = 3
        ' 
        ' SplitLabel
        ' 
        SplitLabel.AutoSize = True
        SplitLabel.Location = New Point(70, 122)
        SplitLabel.Name = "SplitLabel"
        SplitLabel.Size = New Size(183, 20)
        SplitLabel.TabIndex = 4
        SplitLabel.Text = "Split Between Household?"
        ' 
        ' ExpenseRadioGroup
        ' 
        ExpenseRadioGroup.Controls.Add(NoButton)
        ExpenseRadioGroup.Controls.Add(YesButton)
        ExpenseRadioGroup.Location = New Point(3, 145)
        ExpenseRadioGroup.Name = "ExpenseRadioGroup"
        ExpenseRadioGroup.Size = New Size(363, 73)
        ExpenseRadioGroup.TabIndex = 5
        ExpenseRadioGroup.TabStop = False
        ' 
        ' NoButton
        ' 
        NoButton.AutoSize = True
        NoButton.Location = New Point(230, 32)
        NoButton.Name = "NoButton"
        NoButton.Size = New Size(50, 24)
        NoButton.TabIndex = 1
        NoButton.TabStop = True
        NoButton.Text = "No"
        NoButton.UseVisualStyleBackColor = True
        ' 
        ' YesButton
        ' 
        YesButton.AutoSize = True
        YesButton.Location = New Point(67, 32)
        YesButton.Name = "YesButton"
        YesButton.Size = New Size(51, 24)
        YesButton.TabIndex = 0
        YesButton.TabStop = True
        YesButton.Text = "Yes"
        YesButton.UseVisualStyleBackColor = True
        ' 
        ' RoommateExpensePanel
        ' 
        RoommateExpensePanel.Location = New Point(3, 240)
        RoommateExpensePanel.Name = "RoommateExpensePanel"
        RoommateExpensePanel.Size = New Size(357, 204)
        RoommateExpensePanel.TabIndex = 6
        ' 
        ' ExpenseCButton
        ' 
        ExpenseCButton.Location = New Point(256, 471)
        ExpenseCButton.Name = "ExpenseCButton"
        ExpenseCButton.Size = New Size(94, 29)
        ExpenseCButton.TabIndex = 7
        ExpenseCButton.Text = "Create"
        ExpenseCButton.UseVisualStyleBackColor = True
        ' 
        ' ExpensesComponent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(ExpenseCButton)
        Controls.Add(RoommateExpensePanel)
        Controls.Add(ExpenseRadioGroup)
        Controls.Add(SplitLabel)
        Controls.Add(AmountTextbox)
        Controls.Add(ExpenseTextbox)
        Controls.Add(AmountLabel)
        Controls.Add(ExpenseLabel)
        Name = "ExpensesComponent"
        Size = New Size(377, 525)
        ExpenseRadioGroup.ResumeLayout(False)
        ExpenseRadioGroup.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ExpenseLabel As Label
    Friend WithEvents AmountLabel As Label
    Friend WithEvents ExpenseTextbox As TextBox
    Friend WithEvents AmountTextbox As TextBox
    Friend WithEvents SplitLabel As Label
    Friend WithEvents ExpenseRadioGroup As GroupBox
    Friend WithEvents NoButton As RadioButton
    Friend WithEvents YesButton As RadioButton
    Friend WithEvents RoommateExpensePanel As Panel
    Friend WithEvents ExpenseCButton As Button

End Class
