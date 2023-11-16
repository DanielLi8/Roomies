Public Class ExpenseBalanceSheet
    Private summary As Boolean
    Public Sub New(summaryreportoption As Boolean)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        summary = summaryreportoption
        If summary Then
            SheetTypeLabel.Text = "Summary"
            addExpense.Enabled = False
            addExpense.Visible = False
            SummaryLabel.Visible = True


        Else
            SheetTypeLabel.Text = "Balance Sheet"
        End If
        HouseholdLabel.Text = Roomies.HouseholdName.Text
    End Sub

    Private Sub MyExpenseLabel_Click(sender As Object, e As EventArgs) Handles MyExpenseLabel.Click

    End Sub
End Class