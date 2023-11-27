Public Class ExpensesComponent
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
End Class
