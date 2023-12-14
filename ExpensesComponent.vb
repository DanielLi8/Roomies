Public Class ExpensesComponent

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub YesButton_CheckedChanged(sender As Object, e As EventArgs) Handles YesButton.CheckedChanged
        Dim roommateNames As List(Of RoommateClass) = Roomies.getRoommateList()
        RoommateExpensePanel.Controls.Clear()
        For Each roommate As RoommateClass In roommateNames
            Dim checkbox As New CheckBox()
            Dim rname As String = roommate.GetName()
            If rname <> Roomies.TabControl1.SelectedTab.Text Then
                checkbox.Text = roommate.GetName()
                checkbox.AutoSize = True
                RoommateExpensePanel.Controls.Add(checkbox)
            End If
        Next
    End Sub
    Private Sub NoButton_CheckedChanged(sender As Object, e As EventArgs) Handles NoButton.CheckedChanged
        RoommateExpensePanel.Controls.Clear()
    End Sub
    Private Sub ExpenseCEButton_Presses(sender As Object, e As EventArgs) Handles ExpenseCButton.Click
        Dim amountText As String = AmountTextbox.Text
        Dim expenseText As String = ExpenseTextbox.Text
        Dim amount As Decimal
        Dim roommateNames As List(Of RoommateClass) = Roomies.getRoommateList()
        Dim names As List(Of String) = New List(Of String)
        Dim checkedCount As Integer = 1
        names.Add(Roomies.TabControl1.SelectedTab.Text)
        If YesButton.Checked Then
            If Decimal.TryParse(amountText, amount) Then
                For Each ctrl As Control In RoommateExpensePanel.Controls
                    If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                        checkedCount += 1
                        names.Add(ctrl.Text)
                    End If
                Next
                amount = Math.Round((amount / checkedCount), 2)
                For Each rname As String In names
                    For Each roommate As RoommateClass In roommateNames
                        If roommate.GetName() = rname Then
                            roommate.AddExpense(New ExpenseClass(expenseText, CStr(amount), True))
                        End If
                    Next
                Next
            End If
        Else
            If Decimal.TryParse(amountText, amount) Then
                amount = Math.Round((amount / checkedCount), 2)
                For Each roommate As RoommateClass In roommateNames
                    If roommate.GetName() = Roomies.TabControl1.SelectedTab.Text Then
                        roommate.AddExpense(New ExpenseClass(expenseText, CStr(amount), True))
                        Exit For
                    End If
                Next
            End If
        End If
        If Roomies.ETitleLabel.Text = "Summary" Then
            Roomies.GenerateSummaryExpenses(True)
        Else
            Roomies.GenerateSummaryExpenses(False)
        End If
    End Sub

End Class
