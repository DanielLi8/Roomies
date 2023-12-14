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
        ExpenseLabel.Location = New Point(30, 40)
        ExpenseLabel.Name = "ExpenseLabel"
        ExpenseLabel.Size = New Size(53, 15)
        ExpenseLabel.TabIndex = 0
        ExpenseLabel.Text = "Expense:"
        ' 
        ' AmountLabel
        ' 
        AmountLabel.AutoSize = True
        AmountLabel.Location = New Point(30, 78)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New Size(54, 15)
        AmountLabel.TabIndex = 1
        AmountLabel.Text = "Amount:"
        ' 
        ' ExpenseTextbox
        ' 
        ExpenseTextbox.Location = New Point(91, 38)
        ExpenseTextbox.Margin = New Padding(3, 2, 3, 2)
        ExpenseTextbox.Name = "ExpenseTextbox"
        ExpenseTextbox.Size = New Size(245, 23)
        ExpenseTextbox.TabIndex = 2
        ' 
        ' AmountTextbox
        ' 
        AmountTextbox.Location = New Point(91, 76)
        AmountTextbox.Margin = New Padding(3, 2, 3, 2)
        AmountTextbox.Name = "AmountTextbox"
        AmountTextbox.Size = New Size(245, 23)
        AmountTextbox.TabIndex = 3
        ' 
        ' SplitLabel
        ' 
        SplitLabel.AutoSize = True
        SplitLabel.Location = New Point(106, 111)
        SplitLabel.Name = "SplitLabel"
        SplitLabel.Size = New Size(144, 15)
        SplitLabel.TabIndex = 4
        SplitLabel.Text = "Split Between Household?"
        ' 
        ' ExpenseRadioGroup
        ' 
        ExpenseRadioGroup.Controls.Add(NoButton)
        ExpenseRadioGroup.Controls.Add(YesButton)
        ExpenseRadioGroup.Location = New Point(23, 128)
        ExpenseRadioGroup.Margin = New Padding(3, 2, 3, 2)
        ExpenseRadioGroup.Name = "ExpenseRadioGroup"
        ExpenseRadioGroup.Padding = New Padding(3, 2, 3, 2)
        ExpenseRadioGroup.Size = New Size(318, 55)
        ExpenseRadioGroup.TabIndex = 5
        ExpenseRadioGroup.TabStop = False
        ' 
        ' NoButton
        ' 
        NoButton.AutoSize = True
        NoButton.Location = New Point(201, 24)
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
        YesButton.Location = New Point(59, 24)
        YesButton.Margin = New Padding(3, 2, 3, 2)
        YesButton.Name = "YesButton"
        YesButton.Size = New Size(42, 19)
        YesButton.TabIndex = 0
        YesButton.TabStop = True
        YesButton.Text = "Yes"
        YesButton.UseVisualStyleBackColor = True
        ' 
        ' RoommateExpensePanel
        ' 
        RoommateExpensePanel.Location = New Point(23, 199)
        RoommateExpensePanel.Margin = New Padding(3, 2, 3, 2)
        RoommateExpensePanel.Name = "RoommateExpensePanel"
        RoommateExpensePanel.Size = New Size(313, 92)
        RoommateExpensePanel.TabIndex = 6
        ' 
        ' ExpenseCButton
        ' 
        ExpenseCButton.Location = New Point(261, 507)
        ExpenseCButton.Margin = New Padding(3, 2, 3, 2)
        ExpenseCButton.Name = "ExpenseCButton"
        ExpenseCButton.Size = New Size(75, 23)
        ExpenseCButton.TabIndex = 7
        ExpenseCButton.Text = "Create"
        ExpenseCButton.UseVisualStyleBackColor = True
        ' 
        ' ExpensesComponent
        ' 
        AutoScaleMode = AutoScaleMode.None
        Controls.Add(ExpenseCButton)
        Controls.Add(RoommateExpensePanel)
        Controls.Add(ExpenseRadioGroup)
        Controls.Add(SplitLabel)
        Controls.Add(AmountTextbox)
        Controls.Add(ExpenseTextbox)
        Controls.Add(AmountLabel)
        Controls.Add(ExpenseLabel)
        Margin = New Padding(3, 2, 3, 2)
        Name = "ExpensesComponent"
        Size = New Size(365, 595)
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
