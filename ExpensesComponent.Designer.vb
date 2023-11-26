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
        YesButton = New RadioButton()
        NoButton = New RadioButton()
        Panel1 = New Panel()
        ExpenseRadioGroup.SuspendLayout()
        SuspendLayout()
        ' 
        ' ExpenseLabel
        ' 
        ExpenseLabel.AutoSize = True
        ExpenseLabel.Location = New Point(31, 33)
        ExpenseLabel.Name = "ExpenseLabel"
        ExpenseLabel.Size = New Size(66, 20)
        ExpenseLabel.TabIndex = 0
        ExpenseLabel.Text = "Expense:"
        ' 
        ' AmountLabel
        ' 
        AmountLabel.AutoSize = True
        AmountLabel.Location = New Point(31, 84)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New Size(65, 20)
        AmountLabel.TabIndex = 1
        AmountLabel.Text = "Amount:"
        ' 
        ' ExpenseTextbox
        ' 
        ExpenseTextbox.Location = New Point(115, 30)
        ExpenseTextbox.Name = "ExpenseTextbox"
        ExpenseTextbox.Size = New Size(279, 27)
        ExpenseTextbox.TabIndex = 2
        ' 
        ' AmountTextbox
        ' 
        AmountTextbox.Location = New Point(115, 84)
        AmountTextbox.Name = "AmountTextbox"
        AmountTextbox.Size = New Size(279, 27)
        AmountTextbox.TabIndex = 3
        ' 
        ' SplitLabel
        ' 
        SplitLabel.AutoSize = True
        SplitLabel.Location = New Point(115, 127)
        SplitLabel.Name = "SplitLabel"
        SplitLabel.Size = New Size(183, 20)
        SplitLabel.TabIndex = 4
        SplitLabel.Text = "Split Between Household?"
        ' 
        ' ExpenseRadioGroup
        ' 
        ExpenseRadioGroup.Controls.Add(NoButton)
        ExpenseRadioGroup.Controls.Add(YesButton)
        ExpenseRadioGroup.Location = New Point(31, 150)
        ExpenseRadioGroup.Name = "ExpenseRadioGroup"
        ExpenseRadioGroup.Size = New Size(363, 73)
        ExpenseRadioGroup.TabIndex = 5
        ExpenseRadioGroup.TabStop = False
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
        ' Panel1
        ' 
        Panel1.Location = New Point(37, 245)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(357, 277)
        Panel1.TabIndex = 6
        ' 
        ' ExpensesComponent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Controls.Add(ExpenseRadioGroup)
        Controls.Add(SplitLabel)
        Controls.Add(AmountTextbox)
        Controls.Add(ExpenseTextbox)
        Controls.Add(AmountLabel)
        Controls.Add(ExpenseLabel)
        Name = "ExpensesComponent"
        Size = New Size(436, 525)
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
    Friend WithEvents Panel1 As Panel

End Class
