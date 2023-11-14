Public Class TodoCheckbox
    Private Sub EffortIcon_Click(sender As Object, e As EventArgs) Handles EffortIcon.Click
        RecurringLabel.Text = "RecurringLabel: Monthly"
    End Sub



    Private Sub RecurringLabel_Click(sender As Object, e As EventArgs) Handles RecurringLabel.VisibleChanged

    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        RecurringLabel.Text = "Recurring: None"

    End Sub
End Class
