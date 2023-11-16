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
        SharedExpenseLabel1 = New Label()
        SharedExpenseLabel2 = New Label()
        SharedExpenseLabel3 = New Label()
        SharedExpenseLabel4 = New Label()
        SharedExpenseLabel5 = New Label()
        PersonalExpenseLabel1 = New Label()
        PersonalExpenseLabel2 = New Label()
        PersonalExpenseLabel3 = New Label()
        PersonalExpenseLabel4 = New Label()
        PersonalExpenseLabel5 = New Label()
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
        MyExpenseLabel.Location = New Point(27, 405)
        MyExpenseLabel.Name = "MyExpenseLabel"
        MyExpenseLabel.Size = New Size(93, 20)
        MyExpenseLabel.TabIndex = 4
        MyExpenseLabel.Text = "My Expenses"
        ' 
        ' SummaryLabel
        ' 
        SummaryLabel.AutoSize = True
        SummaryLabel.Location = New Point(27, 672)
        SummaryLabel.Name = "SummaryLabel"
        SummaryLabel.Size = New Size(49, 20)
        SummaryLabel.TabIndex = 5
        SummaryLabel.Text = "Total: "
        ' 
        ' SharedExpenseLabel1
        ' 
        SharedExpenseLabel1.AutoSize = True
        SharedExpenseLabel1.Location = New Point(29, 177)
        SharedExpenseLabel1.Name = "SharedExpenseLabel1"
        SharedExpenseLabel1.Size = New Size(117, 20)
        SharedExpenseLabel1.TabIndex = 6
        SharedExpenseLabel1.Text = "SharedExpense1"
        SharedExpenseLabel1.Visible = False
        ' 
        ' SharedExpenseLabel2
        ' 
        SharedExpenseLabel2.AutoSize = True
        SharedExpenseLabel2.Location = New Point(29, 225)
        SharedExpenseLabel2.Name = "SharedExpenseLabel2"
        SharedExpenseLabel2.Size = New Size(117, 20)
        SharedExpenseLabel2.TabIndex = 7
        SharedExpenseLabel2.Text = "SharedExpense2"
        SharedExpenseLabel2.Visible = False
        ' 
        ' SharedExpenseLabel3
        ' 
        SharedExpenseLabel3.AutoSize = True
        SharedExpenseLabel3.Location = New Point(29, 271)
        SharedExpenseLabel3.Name = "SharedExpenseLabel3"
        SharedExpenseLabel3.Size = New Size(117, 20)
        SharedExpenseLabel3.TabIndex = 8
        SharedExpenseLabel3.Text = "SharedExpense3"
        SharedExpenseLabel3.Visible = False
        ' 
        ' SharedExpenseLabel4
        ' 
        SharedExpenseLabel4.AutoSize = True
        SharedExpenseLabel4.Location = New Point(29, 316)
        SharedExpenseLabel4.Name = "SharedExpenseLabel4"
        SharedExpenseLabel4.Size = New Size(117, 20)
        SharedExpenseLabel4.TabIndex = 9
        SharedExpenseLabel4.Text = "SharedExpense4"
        SharedExpenseLabel4.Visible = False
        ' 
        ' SharedExpenseLabel5
        ' 
        SharedExpenseLabel5.AutoSize = True
        SharedExpenseLabel5.Location = New Point(29, 365)
        SharedExpenseLabel5.Name = "SharedExpenseLabel5"
        SharedExpenseLabel5.Size = New Size(117, 20)
        SharedExpenseLabel5.TabIndex = 10
        SharedExpenseLabel5.Text = "SharedExpense5"
        SharedExpenseLabel5.Visible = False
        ' 
        ' PersonalExpenseLabel1
        ' 
        PersonalExpenseLabel1.AutoSize = True
        PersonalExpenseLabel1.Location = New Point(27, 448)
        PersonalExpenseLabel1.Name = "PersonalExpenseLabel1"
        PersonalExpenseLabel1.Size = New Size(126, 20)
        PersonalExpenseLabel1.TabIndex = 11
        PersonalExpenseLabel1.Text = "PersonalExpense1"
        PersonalExpenseLabel1.Visible = False
        ' 
        ' PersonalExpenseLabel2
        ' 
        PersonalExpenseLabel2.AutoSize = True
        PersonalExpenseLabel2.Location = New Point(27, 489)
        PersonalExpenseLabel2.Name = "PersonalExpenseLabel2"
        PersonalExpenseLabel2.Size = New Size(126, 20)
        PersonalExpenseLabel2.TabIndex = 12
        PersonalExpenseLabel2.Text = "PersonalExpense2"
        PersonalExpenseLabel2.Visible = False
        ' 
        ' PersonalExpenseLabel3
        ' 
        PersonalExpenseLabel3.AutoSize = True
        PersonalExpenseLabel3.Location = New Point(27, 534)
        PersonalExpenseLabel3.Name = "PersonalExpenseLabel3"
        PersonalExpenseLabel3.Size = New Size(126, 20)
        PersonalExpenseLabel3.TabIndex = 13
        PersonalExpenseLabel3.Text = "PersonalExpense3"
        PersonalExpenseLabel3.Visible = False
        ' 
        ' PersonalExpenseLabel4
        ' 
        PersonalExpenseLabel4.AutoSize = True
        PersonalExpenseLabel4.Location = New Point(27, 577)
        PersonalExpenseLabel4.Name = "PersonalExpenseLabel4"
        PersonalExpenseLabel4.Size = New Size(126, 20)
        PersonalExpenseLabel4.TabIndex = 14
        PersonalExpenseLabel4.Text = "PersonalExpense4"
        PersonalExpenseLabel4.Visible = False
        ' 
        ' PersonalExpenseLabel5
        ' 
        PersonalExpenseLabel5.AutoSize = True
        PersonalExpenseLabel5.Location = New Point(27, 618)
        PersonalExpenseLabel5.Name = "PersonalExpenseLabel5"
        PersonalExpenseLabel5.Size = New Size(126, 20)
        PersonalExpenseLabel5.TabIndex = 15
        PersonalExpenseLabel5.Text = "PersonalExpense5"
        PersonalExpenseLabel5.Visible = False
        ' 
        ' ExpenseBalanceSheet
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(399, 741)
        Controls.Add(PersonalExpenseLabel5)
        Controls.Add(PersonalExpenseLabel4)
        Controls.Add(PersonalExpenseLabel3)
        Controls.Add(PersonalExpenseLabel2)
        Controls.Add(PersonalExpenseLabel1)
        Controls.Add(SharedExpenseLabel5)
        Controls.Add(SharedExpenseLabel4)
        Controls.Add(SharedExpenseLabel3)
        Controls.Add(SharedExpenseLabel2)
        Controls.Add(SharedExpenseLabel1)
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
    Friend WithEvents SharedExpenseLabel1 As Label
    Friend WithEvents SharedExpenseLabel2 As Label
    Friend WithEvents SharedExpenseLabel3 As Label
    Friend WithEvents SharedExpenseLabel4 As Label
    Friend WithEvents SharedExpenseLabel5 As Label
    Friend WithEvents PersonalExpenseLabel1 As Label
    Friend WithEvents PersonalExpenseLabel2 As Label
    Friend WithEvents PersonalExpenseLabel3 As Label
    Friend WithEvents PersonalExpenseLabel4 As Label
    Friend WithEvents PersonalExpenseLabel5 As Label
End Class
