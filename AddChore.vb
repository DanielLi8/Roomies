Public Class AddChore

    Private myRoomies As Roomies
    Public Sub New(myRoomies As Roomies)

        ' This call is required by the designer.
        InitializeComponent()
        Me.myRoomies = myRoomies
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub AddChore_Load(sender As Object, e As EventArgs) Handles MyBase.Activated

        ' Clear existing items in the ComboBox
        Assignee.Items.Clear()

        ' Add roommates to ComboBox
        For Each roommate In myRoomies.getRoommateList
            Assignee.Items.Add(roommate.GetName)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Dim chore As New ChoreClass
        'set chore name
        chore.Name = ChoreInput.Text
        'Set recurring
        If RecurringDaily.Checked Then
            chore.recurring = "Daily"
        ElseIf RecurringWeekly.Checked Then
            chore.recurring = "Weekly"
        ElseIf RecurringMonthly.Checked Then
            chore.recurring = "Monthly"
        Else
            chore.recurring = "None"
        End If

        'set EffortRating
        If Effort1.Checked Then
            chore.Effort = 1
        ElseIf Effort2.Checked Then
            chore.Effort = 2
        ElseIf Effort3.Checked Then
            chore.Effort = 3
        ElseIf Effort4.Checked Then
            chore.Effort = 4
        ElseIf Effort5.Checked Then
            chore.Effort = 5
        End If

        'Assign roommate associated with the chore
        chore.Roommate = Assignee.SelectedIndex
        ' fix the below line add chore to selected index

        'Assign chore associated to roommate
        Dim rList = Roomies.getRoommateList()
        rList(Assignee.SelectedIndex).AddChore(chore)

        ' will eventually remove this line
        myRoomies.AddChoreList(chore)


        'close window
        Me.Close()

    End Sub
End Class