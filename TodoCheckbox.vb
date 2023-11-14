Public Class TodoCheckbox


    Private Sub RecurringLabel_Click(sender As Object, e As EventArgs) Handles RecurringLabel.VisibleChanged, RecurringLabel.Resize
        EffortIcon.Left = RecurringLabel.Right + 10
        EffortLabel.Left = RecurringLabel.Right + 30
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        RecurringLabel.Text = "Recurring: Monthly"
    End Sub
End Class
