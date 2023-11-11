Public Class Roomies
    Private Sub Roomies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = CustomCursor.CirclePointCursor

    End Sub

    End Sub

    Private Sub AddHouseholdBtn_Click(sender As Object, e As EventArgs) Handles AddHouseholdBtn.Click
        Dim householdform As New HouseholdDetails(Me)


        householdform.Location = Me.Location
        householdform.Show()
        AddHouseholdBtn.Enabled = False

    End Sub


End Class