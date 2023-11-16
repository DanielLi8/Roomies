<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpenseBalanceSheet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        HouseholdLabel = New Label()
        SheetTypeLabel = New Label()
        addExpense = New Button()
        SharedLabel = New Label()
        MyExpenseLabel = New Label()
        SummaryLabel = New Label()
        SuspendLayout()
        ' 
        ' HouseholdLabel
        ' 
        HouseholdLabel.AutoSize = True
        HouseholdLabel.Location = New Point(27, 35)
        HouseholdLabel.Name = "HouseholdLabel"
        HouseholdLabel.Size = New Size(97, 20)
        HouseholdLabel.TabIndex = 0
        HouseholdLabel.Text = "House_Name"
        ' 
        ' SheetTypeLabel
        ' 
        SheetTypeLabel.AutoSize = True
        SheetTypeLabel.Location = New Point(27, 73)
        SheetTypeLabel.Name = "SheetTypeLabel"
        SheetTypeLabel.Size = New Size(77, 20)
        SheetTypeLabel.TabIndex = 1
        SheetTypeLabel.Text = "SheetType"
        ' 
        ' addExpense
        ' 
        addExpense.Image = My.Resources.Resources.plus_sign
        addExpense.Location = New Point(282, 69)
        addExpense.Name = "addExpense"
        addExpense.Size = New Size(31, 29)
        addExpense.TabIndex = 2
        addExpense.UseVisualStyleBackColor = True
        ' 
        ' SharedLabel
        ' 
        SharedLabel.AutoSize = True
        SharedLabel.Location = New Point(27, 137)
        SharedLabel.Name = "SharedLabel"
        SharedLabel.Size = New Size(122, 20)
        SharedLabel.TabIndex = 3
        SharedLabel.Text = "Shared Expenses:"
        ' 
        ' MyExpenseLabel
        ' 
        MyExpenseLabel.AutoSize = True
        MyExpenseLabel.Location = New Point(27, 402)
        MyExpenseLabel.Name = "MyExpenseLabel"
        MyExpenseLabel.Size = New Size(93, 20)
        MyExpenseLabel.TabIndex = 4
        MyExpenseLabel.Text = "My Expenses"
        ' 
        ' SummaryLabel
        ' 
        SummaryLabel.AutoSize = True
        SummaryLabel.Location = New Point(27, 636)
        SummaryLabel.Name = "SummaryLabel"
        SummaryLabel.Size = New Size(49, 20)
        SummaryLabel.TabIndex = 5
        SummaryLabel.Text = "Total: "
        ' 
        ' ExpenseBalanceSheet
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(399, 741)
        Controls.Add(SummaryLabel)
        Controls.Add(MyExpenseLabel)
        Controls.Add(SharedLabel)
        Controls.Add(addExpense)
        Controls.Add(SheetTypeLabel)
        Controls.Add(HouseholdLabel)
        Name = "ExpenseBalanceSheet"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HouseholdLabel As Label
    Friend WithEvents SheetTypeLabel As Label
    Friend WithEvents addExpense As Button
    Friend WithEvents SharedLabel As Label
    Friend WithEvents MyExpenseLabel As Label
    Friend WithEvents SummaryLabel As Label
End Class
