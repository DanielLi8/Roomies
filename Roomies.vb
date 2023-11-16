Imports System.Globalization
Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip

Public Class Roomies

    Private Sub Roomies_Load(sender As Object, e As EventArgs)
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

    Public Sub UpdateChoreList(newChore As ChoreClass, index As Integer)
        ChoreList(index) = newChore
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


        If RoommateList.Any Then
            AddHouseholdBtn.Enabled = False
            Alice.Text = RoommateList(1).GetName()
        End If


    End Sub
#End Region


#Region "Methods for selecting menu panel controls"
    Dim greenClicked As Color = Color.FromArgb(62, 90, 60)
    Dim greendefault As Color = Color.FromArgb(89, 121, 87)
    Private Sub MenuBtn_Click(sender As Object, e As EventArgs) Handles TodoBtn.Click, ToDoBtnAlice.Click
        'Show Panels
        TodoViewPanel.Visible = True
        ToDoViewPanelAlice.Visible = True

        'Hide Panels
        CompletedPerspective.Visible = False
        CompletedPerspective2.Visible = False

        TodoBtn.BackColor = greenClicked
        CompletedBtn.BackColor = greendefault
        ExpensesBtn.BackColor = greendefault
        ExpenseSummaryBtn.BackColor = greendefault

        ToDoBtnAlice.BackColor = greenClicked
        CompletedBtnAlice.BackColor = greendefault
        ExpenseBtnAlice.BackColor = greendefault
        SummaryBtnAlice.BackColor = greendefault
    End Sub

    Private Sub CompletedBtn_Click(sender As Object, e As EventArgs) Handles CompletedBtn.Click, CompletedBtnAlice.Click
        'Show Panels
        CompletedPerspective.Visible = True
        CompletedPerspective2.Visible = True

        'Hide Panels
        TodoViewPanel.Visible = False
        ToDoViewPanelAlice.Visible = False




        TodoBtn.BackColor = greendefault
        CompletedBtn.BackColor = greenClicked
        ExpensesBtn.BackColor = greendefault
        ExpenseSummaryBtn.BackColor = greendefault

        ToDoBtnAlice.BackColor = greendefault
        CompletedBtnAlice.BackColor = greenClicked
        ExpenseBtnAlice.BackColor = greendefault
        SummaryBtnAlice.BackColor = greendefault
    End Sub

    Private Sub ExpensesBtn_Click(sender As Object, e As EventArgs) Handles ExpensesBtn.Click, ExpenseBtnAlice.Click
        TodoBtn.BackColor = greendefault
        CompletedBtn.BackColor = greendefault
        ExpensesBtn.BackColor = greenClicked
        ExpenseSummaryBtn.BackColor = greendefault

        ToDoBtnAlice.BackColor = greendefault
        CompletedBtnAlice.BackColor = greendefault
        ExpenseBtnAlice.BackColor = greenClicked
        SummaryBtnAlice.BackColor = greendefault
    End Sub

    Private Sub ExpenseSummaryBtn_Click(sender As Object, e As EventArgs) Handles ExpenseSummaryBtn.Click, SummaryBtnAlice.Click
        TodoBtn.BackColor = greendefault
        CompletedBtn.BackColor = greendefault
        ExpensesBtn.BackColor = greendefault
        ExpenseSummaryBtn.BackColor = greenClicked

        ToDoBtnAlice.BackColor = greendefault
        CompletedBtnAlice.BackColor = greendefault
        ExpenseBtnAlice.BackColor = greendefault
        SummaryBtnAlice.BackColor = greenClicked
    End Sub
#End Region


#Region "List to keep track of todocheckbox that are dynamically created in the household"
    Private todoboxList As New List(Of TodoCheckbox)()

    Public Sub AddTodoboxList(newTodobox As TodoCheckbox)
        todoboxList.Add(newTodobox)
    End Sub
    Public Sub UpdateTodoBox(newTodobox As TodoCheckbox, index As Integer)
        todoboxList(index) = newTodobox
    End Sub
    Public Function getTodoboxList() As List(Of TodoCheckbox)
        Return todoboxList
    End Function


#End Region


#Region "Adding chore functionality"
    Private Sub AddChoreBtn_Click(sender As Object, e As EventArgs) Handles AddChoreBtn.Click, AliceAddChoreBtn.Click

        Dim choreAdd As New AddChore()
        choreAdd.ShowDialog()

        AddTodoboxToPanel()
        AliceAddTodoboxToPanel()
    End Sub

    Public Sub AddTodoboxToPanel()
        User1ChoreCheckboxPanel.Controls.Clear()
        User2ChoreCheckboxPanel.Controls.Clear()
        Dim User1VerticalSpacing As Integer = 0
        Dim User2VerticalSpacing As Integer = 0
        Dim position As Integer = 0

        For Each chore In ChoreList

            Dim todobox As New TodoCheckbox(chore.Name, chore.recurring, chore.Effort, position)
            Me.AddTodoboxList(todobox)
            ' fix below to add to panel depending on which user
            If chore.Roommate = 0 Then
                todobox.Location = New Point(0, 58 * User1VerticalSpacing)
                User1ChoreCheckboxPanel.Controls.Add(todobox)
                User1VerticalSpacing += 1

            ElseIf chore.Roommate = 1 Then
                todobox.Location = New Point(0, 58 * User2VerticalSpacing)
                User2ChoreCheckboxPanel.Controls.Add(todobox)
                User2VerticalSpacing += 1
            End If
            position += 1
        Next

    End Sub

    Public Sub AliceAddTodoboxToPanel()
        AliceMeTodoboxPanel.Controls.Clear()
        AliceBobTodoPanel.Controls.Clear()
        Dim User1VerticalSpacing As Integer = 0
        Dim User2VerticalSpacing As Integer = 0
        Dim position As Integer = 0

        For Each chore In ChoreList

            Dim todobox As New TodoCheckbox(chore.Name, chore.recurring, chore.Effort, position)
            Me.AddTodoboxList(todobox)
            ' fix below to add to panel depending on which user
            If chore.Roommate = 0 Then
                todobox.Location = New Point(0, 58 * User1VerticalSpacing)
                AliceBobTodoPanel.Controls.Add(todobox)
                User1VerticalSpacing += 1

            ElseIf chore.Roommate = 1 Then
                todobox.Location = New Point(0, 58 * User2VerticalSpacing)
                AliceMeTodoboxPanel.Controls.Add(todobox)
                User2VerticalSpacing += 1
            End If
            position += 1
        Next

    End Sub
#End Region

#Region "CompletedCheckbox panel view"

    'List to keep track of todocheckbox that are dynamically created in the household
    Private CompletedCheckBoxList As New List(Of CheckBox)()

    Public Sub AddCompetedCheckBoxList(newCheckBox As CheckBox)
        CompletedCheckBoxList.Add(newCheckBox)
    End Sub
    Public Sub UpdateCompetedCheckBox(newCheckBox As CheckBox, index As Integer)
        CompletedCheckBoxList(index) = newCheckBox
    End Sub
    Public Function getCompetedCheckBox() As List(Of CheckBox)
        Return CompletedCheckBoxList
    End Function



    Public Sub UpdateCompletedPanelView()
        CompletedChoreBobPanel.Controls.Clear()

        Dim VerticalSpacing As Integer = 0

        For Each CompletedCheckBox In CompletedCheckBoxList

            CompletedCheckBox.Font = New Font("Arial", 12.0F, FontStyle.Strikeout, GraphicsUnit.Point)
            ' fix below to add to panel depending on which user
            CompletedCheckBox.Location = New Point(0, 30 * VerticalSpacing)
            CompletedChoreBobPanel.Controls.Add(CompletedCheckBox)

            VerticalSpacing += 1

        Next

    End Sub

    Public Sub AliceUpdateCompletedPanelView()
        CompletedChoreAlicePanel.Controls.Clear()

        Dim VerticalSpacing As Integer = 0

        For Each CompletedCheckBox In CompletedCheckBoxList

            CompletedCheckBox.Font = New Font("Arial", 12.0F, FontStyle.Strikeout, GraphicsUnit.Point)
            ' fix below to add to panel depending on which user
            CompletedCheckBox.Location = New Point(0, 30 * VerticalSpacing)
            CompletedChoreAlicePanel.Controls.Add(CompletedCheckBox)
            VerticalSpacing += 1

        Next

    End Sub
#End Region


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDate()
        Dim currentUser As New RoommateClass("Bob", "user_a@gmail.com")
        Me.AddRoommate(currentUser)
        Dim currentUser2 As New RoommateClass("Alice", "user_a@gmail.com")
        Me.AddRoommate(currentUser2)

        CompletedPerspective.Parent = Bob
        CompletedPerspective2.Parent = UserB

    End Sub

    Private Sub UpdateDate()
        Dim currentDate As DateTime = DateTime.Now
        Dim formattedDate As String = currentDate.ToString("ddd, MMM d", CultureInfo.InvariantCulture)

        DateLabel.Text = "Today: " & formattedDate
        AliceDateLabel.Text = "Today: " & formattedDate
        CompletedDateLabelAlice.Text = "Today: " & formattedDate
        CompletedDateLabelBob.Text = "Today: " & formattedDate
    End Sub


End Class
