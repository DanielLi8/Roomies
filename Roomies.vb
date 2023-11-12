Public Class Roomies
    Private Sub Roomies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = CustomCursor.CirclePointCursor


    End Sub


    Private Sub AddHouseholdBtn_Click(sender As Object, e As EventArgs) Handles AddHouseholdBtn.Click
        Dim householdform As New HouseholdDetails(Me)


        householdform.Location = New Point(PhoneBackground.Location.X, PhoneBackground.Location.Y + 55)
        householdform.Show()
        AddHouseholdBtn.Enabled = False

    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ' Get the X and Y coordinates of the mouse movement
        Dim mouseX As Integer = e.X
        Dim mouseY As Integer = e.Y

        ' Display the coordinates (you can replace this with your own logic)
        Label1.Text = $"Mouse Coordinates: X={mouseX}, Y={mouseY}"
    End Sub
End Class
