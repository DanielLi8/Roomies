Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip

Public Class Roomies

    Private Sub Roomies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = CustomCursor.CirclePointCursor
    End Sub


#Region "List to keep track of roommates in the household"
    Private RoommateList As New List(Of RoommateClass)()

    Public Sub AddRoommate(newRoommate As RoommateClass)
        RoommateList.Add(newRoommate)
    End Sub

    Public Function getRoommateList() As List(Of RoommateClass)
        Return RoommateList
    End Function

#End Region


#Region "List to keep track of chores in the household"
    Private ChoreList As New List(Of ChoreClass)()

    Public Sub AddChoreList(newChore As ChoreClass)
        ChoreList.Add(newChore)
    End Sub

    Public Function getChoreList() As List(Of ChoreClass)
        Return ChoreList
    End Function
#End Region




#Region "household"
    Private Sub AddHouseholdBtn_Click(sender As Object, e As EventArgs) Handles AddHouseholdBtn.Click
        Dim householdform As New HouseholdDetails(Me)

        householdform.Location = New Point(householdform.Location.X, householdform.Location.Y + 12)
        householdform.ShowDialog()
        AddHouseholdBtn.Enabled = False

    End Sub
#End Region

#Region "Methods for selecting menu panel controls"
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
#End Region


    Private Sub AddChoreBtn_Click(sender As Object, e As EventArgs) Handles AddChoreBtn.Click
        Dim choreAdd As New AddChore(Me)
        choreAdd.ShowDialog()

        Dim verticalSpacing As Integer = 0
        For Each chore In ChoreList
            Dim todobox As New TodoCheckbox(chore.Name, chore.recurring, chore.Effort)

            todobox.Location = New Point(0, 58 * verticalSpacing)
            ChoreCheckboxPanel.Controls.Add(todobox)
            verticalSpacing += 1
        Next

    End Sub


End Class
