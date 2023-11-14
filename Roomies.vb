Imports System.Net.Security

Public Class Roomies

    'List to keep track of roommates in the household
    Private RoommateList As New List(Of RoommateClass)()

    Public Sub AddRoommate(newRoommate As RoommateClass)
        RoommateList.Add(newRoommate)
    End Sub

    Private Sub Roomies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = CustomCursor.CirclePointCursor

    End Sub


    Private Sub AddHouseholdBtn_Click(sender As Object, e As EventArgs) Handles AddHouseholdBtn.Click
        Dim householdform As New HouseholdDetails(Me)

        householdform.Location = New Point(householdform.Location.X, householdform.Location.Y + 12)
        householdform.Show()
        AddHouseholdBtn.Enabled = False

    End Sub



    Dim greenClicked As Color = Color.FromArgb(62, 90, 60)
    Dim greendefault As Color = Color.FromArgb(89, 121, 87)
    Private Sub MenuBtn_Click(sender As Object, e As EventArgs) Handles TodoBtn.Click

        TodoBtn.BackColor = greenClicked
        CompletedBtn.BackColor = greendefault
        ExpensesBtn.BackColor = greendefault
        ExpenseSummaryBtn.BackColor = greendefault

    End Sub

    Private Sub CompletedBtn_Click(sender As Object, e As EventArgs) Handles CompletedBtn.Click
        TodoBtn.BackColor = greendefault
        CompletedBtn.BackColor = greenClicked
        ExpensesBtn.BackColor = greendefault
        ExpenseSummaryBtn.BackColor = greendefault
    End Sub

    Private Sub ExpensesBtn_Click(sender As Object, e As EventArgs) Handles ExpensesBtn.Click
        TodoBtn.BackColor = greendefault
        CompletedBtn.BackColor = greendefault
        ExpensesBtn.BackColor = greenClicked
        ExpenseSummaryBtn.BackColor = greendefault
    End Sub

    Private Sub ExpenseSummaryBtn_Click(sender As Object, e As EventArgs) Handles ExpenseSummaryBtn.Click
        TodoBtn.BackColor = greendefault
        CompletedBtn.BackColor = greendefault
        ExpensesBtn.BackColor = greendefault
        ExpenseSummaryBtn.BackColor = greenClicked
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ChoreCheckbox.CheckedChanged
        If ChoreCheckbox.Checked Then
            ChoreCheckbox.Font = New Font("Arial", 9.75F, FontStyle.Strikeout, GraphicsUnit.Point)
        Else
            ChoreCheckbox.Font = New Font("Arial", 9.75F, GraphicsUnit.Point)
        End If
        'Label1.Text = RoommateList(1).GetName

    End Sub


End Class
