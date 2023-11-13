Imports System.Net.Security

Public Class Roomies
    Private Sub Roomies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = CustomCursor.CirclePointCursor



        'Test codes
        Dim obj As New RoommateClass()
        obj.AddChore("Shallllo")
        obj.AddChore("Wwi")
        obj.AddChore("Dad")
        Label1.Text = obj.FindChore("Dad")
        'Test ends here
    End Sub


    Private Sub AddHouseholdBtn_Click(sender As Object, e As EventArgs) Handles AddHouseholdBtn.Click
        Dim householdform As New HouseholdDetails(Me)

        householdform.Location = New Point(householdform.Location.X, householdform.Location.Y + 12)
        householdform.Show()
        AddHouseholdBtn.Enabled = False

    End Sub

    'For testing
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ' Get the X and Y coordinates of the mouse movement
        Dim mouseX As Integer = e.X
        Dim mouseY As Integer = e.Y

        ' Label1.Text = $"Mouse Coordinates: X={mouseX}, Y={mouseY}"
    End Sub


End Class
