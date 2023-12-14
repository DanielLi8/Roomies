Imports System.Diagnostics.Eventing.Reader
Imports System.Globalization
Imports System.Net.Security
Imports System.Security.Permissions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports System.Xml.Schema

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
    Private BobChoreCount As Integer
    Private AliceChoreCount As Integer
    Public Sub AddChoreList(newChore As ChoreClass)
        ChoreList.Add(newChore)
        UpdateCount()

    End Sub

    Public Sub UpdateChoreList(newChore As ChoreClass, index As Integer)
        ChoreList(index) = newChore
        UpdateCount()
    End Sub

    Public Sub RemoveChoreList(index As Integer)
        Dim newChore As New ChoreClass
        ChoreList(index) = newChore
        UpdateCount()
    End Sub
    Public Function getChoreList() As List(Of ChoreClass)
        Return ChoreList
    End Function

    Public Function FindChore(choreToFind As ChoreClass) As ChoreClass
        Dim foundChore As ChoreClass = ChoreList.Find(Function(chore) _
        chore.Name = choreToFind.Name AndAlso
        chore.recurring = choreToFind.recurring AndAlso
        chore.Effort = choreToFind.Effort)

        Return foundChore

    End Function
    Public Sub UpdateCount()
        AliceChoreCount = 0
        BobChoreCount = 0
        For Each chore In ChoreList
            If chore.Roommate = 1 Then
                AliceChoreCount += 1
            ElseIf chore.Roommate = 0 Then
                BobChoreCount += 1
            End If
        Next
    End Sub
#End Region


#Region "household"
    Private Sub AddHouseholdBtn_Click(sender As Object, e As EventArgs) Handles BobAddHouseholdBtn.Click, AliceAddHouseholdBtn.Click
        Dim householdform As New HouseholdDetails(Me)

        householdform.Location = New Point(householdform.Location.X, householdform.Location.Y + 12)
        householdform.ShowDialog()


        If RoommateList.Any Then
            BobAddHouseholdBtn.Enabled = False
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
        ExpensesPanel.Visible = False
        ExpensesPanel2.Visible = False

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
        ExpensesPanel.Visible = False
        ExpensesPanel2.Visible = False




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
        ExpensesPanel.Visible = True
        ExpensesPanel2.Visible = True
        TodoViewPanel.Visible = False
        ToDoViewPanelAlice.Visible = False
        CompletedPerspective.Visible = False
        CompletedPerspective2.Visible = False

        TodoBtn.BackColor = greendefault
        CompletedBtn.BackColor = greendefault
        ExpensesBtn.BackColor = greenClicked
        ExpenseSummaryBtn.BackColor = greendefault

        ToDoBtnAlice.BackColor = greendefault
        CompletedBtnAlice.BackColor = greendefault
        ExpenseBtnAlice.BackColor = greenClicked
        SummaryBtnAlice.BackColor = greendefault

        GenerateSummaryExpenses(False)
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

        GenerateSummaryExpenses(True)
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
    Private userNum As Integer
    Private Sub AddChoreBtn_Click(sender As Object, e As EventArgs) Handles AddChoreBtn.Click, AliceAddChoreBtn.Click
        If TabControl1.SelectedTab Is BobTab Then
            userNum = 0
        Else
            userNum = 1
        End If

        Dim choreAdd As New AddChore(BobChoreCount, AliceChoreCount, userNum)
        choreAdd.ShowDialog()

        AddTodoboxToPanel()
        AliceAddTodoboxToPanel()

    End Sub


    Public Sub AddTodoboxToPanel()
        User1ChoreCheckboxPanel.Controls.Clear()
        User2ChoreCheckboxPanel.Controls.Clear()
        Dim BobUser1VerticalSpacing As Integer = 0
        Dim BobUser2VerticalSpacing As Integer = 0
        Dim Bobposition As Integer = 0

        For Each chore In ChoreList
            If chore.Name = "" Then
                Bobposition += 1
                Continue For
            End If

            ' fix below to add to panel depending on which user
            If chore.Roommate = 0 Then
                Dim todobox As New TodoCheckbox(chore.Name, chore.recurring, chore.Effort, Bobposition, "Bob", BobChoreCount, AliceChoreCount)
                Me.AddTodoboxList(todobox)

                todobox.Location = New Point(0, 58 * BobUser1VerticalSpacing)
                User1ChoreCheckboxPanel.Controls.Add(todobox)
                BobUser1VerticalSpacing += 1

            ElseIf chore.Roommate = 1 Then
                Dim todobox As New TodoCheckbox(chore.Name, chore.recurring, chore.Effort, Bobposition, "Alice", BobChoreCount, AliceChoreCount)
                Me.AddTodoboxList(todobox)
                todobox.Location = New Point(0, 58 * BobUser2VerticalSpacing)
                User2ChoreCheckboxPanel.Controls.Add(todobox)
                BobUser2VerticalSpacing += 1
            End If
            Bobposition += 1

        Next

    End Sub


    Public Sub AliceAddTodoboxToPanel()
        AliceMeTodoboxPanel.Controls.Clear()
        AliceBobTodoPanel.Controls.Clear()
        Dim AliceUser1VerticalSpacing As Integer = 0
        Dim AliceUser2VerticalSpacing As Integer = 0
        Dim AlicePosition As Integer = 0

        For Each chore In ChoreList
            If chore.Name = "" Then
                AlicePosition += 1

                Continue For
            End If

            ' fix below to add to panel depending on which user
            If chore.Roommate = 0 Then
                Dim todobox As New TodoCheckbox(chore.Name, chore.recurring, chore.Effort, AlicePosition, "Bob", BobChoreCount, AliceChoreCount)
                Me.AddTodoboxList(todobox)
                todobox.Location = New Point(0, 58 * AliceUser1VerticalSpacing)
                AliceBobTodoPanel.Controls.Add(todobox)
                AliceUser1VerticalSpacing += 1

            ElseIf chore.Roommate = 1 Then
                Dim todobox As New TodoCheckbox(chore.Name, chore.recurring, chore.Effort, AlicePosition, "Alice", BobChoreCount, AliceChoreCount)
                Me.AddTodoboxList(todobox)
                todobox.Location = New Point(0, 58 * AliceUser2VerticalSpacing)
                AliceMeTodoboxPanel.Controls.Add(todobox)
                AliceUser2VerticalSpacing += 1
            End If
            AlicePosition += 1

        Next

    End Sub
#End Region

#Region "CompletedCheckbox panel view"

    'List to keep track of todocheckbox that are dynamically created in the household
    Private CompletedCheckBoxList As New List(Of Completedcheckboxvb)()

    Public Sub AddCompetedCheckBoxList(newCheckBox As Completedcheckboxvb)
        CompletedCheckBoxList.Add(newCheckBox)
    End Sub
    Public Sub UpdateCompetedCheckBox(newCheckBox As Completedcheckboxvb, index As Integer)
        CompletedCheckBoxList(index) = newCheckBox
    End Sub
    Public Function getCompetedCheckBox() As List(Of Completedcheckboxvb)
        Return CompletedCheckBoxList
    End Function



    Public Sub UpdateCompletedPanelView()
        ' CompletedChoreBobPanel.Controls.Clear()

        Dim VerticalSpacing As Integer = 0

        For Each CompletedCheckBox In CompletedCheckBoxList

            ' fix below to add to panel depending on which user
            CompletedCheckBox.Location = New Point(0, 58 * VerticalSpacing)
            CompletedChoreBobPanel.Controls.Add(CompletedCheckBox)

            VerticalSpacing += 1

        Next

    End Sub

    Public Sub AliceUpdateCompletedPanelView()
        ' CompletedChoreAlicePanel.Controls.Clear()

        Dim VerticalSpacing As Integer = 0

        For Each CompletedCheckBox In CompletedCheckBoxList
            Dim newCheckBox As New Completedcheckboxvb
            newCheckBox = CompletedCheckBox

            ' fix below to add to panel depending on which user
            newCheckBox.Location = New Point(0, 58 * VerticalSpacing)
            CompletedChoreAlicePanel.Controls.Add(newCheckBox)
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

        'setting panel locations for bob view
        TodoViewPanel.Parent = BobMasterPanel
        TodoViewPanel.Location = New Point(0, 0)
        CompletedPerspective.Parent = BobMasterPanel
        CompletedPerspective.Location = New Point(0, 0)
        ExpensesPanel.Parent = BobMasterPanel
        ExpensesPanel.Location = New Point(0, 0)

        'setting panel locations for bob view
        ToDoViewPanelAlice.Parent = AliceMasterPanel
        ToDoViewPanelAlice.Location = New Point(0, 0)
        CompletedPerspective2.Parent = AliceMasterPanel
        CompletedPerspective2.Location = New Point(0, 0)
        ExpensesPanel2.Parent = AliceMasterPanel
        ExpensesPanel2.Location = New Point(0, 0)



    End Sub

    Private Sub UpdateDate()
        Dim currentDate As DateTime = DateTime.Now
        Dim formattedDate As String = currentDate.ToString("ddd, MMM d", CultureInfo.InvariantCulture)

        DateLabel.Text = "Today: " & formattedDate
        AliceDateLabel.Text = "Today: " & formattedDate
        CompletedDateLabelAlice.Text = "Today: " & formattedDate
        CompletedDateLabelBob.Text = "Today: " & formattedDate
    End Sub

    Public Sub GenerateSummaryExpenses(summary As Boolean)
        If summary Then
            ETitleLabel.Text = "Summary"
            EButton.Visible = False
            ESummaryLabel.Visible = True
        Else
            ETitleLabel.Text = "Balence Sheet"
            EButton.Visible = True
            ESummaryLabel.Visible = False
        End If
        CalculateTotalExpense()
        GenerateSharedExpenses()
        GeneratePersonalExpenses()
    End Sub
#Region "Calculating subs for Expense Features"
    Private Sub CalculateTotalExpense()
        Dim selectedRoommateName As String = TabControl1.SelectedTab.Text
        Dim totalExpense As Decimal = 0
        ' Loop through all roommates
        For Each roommate As RoommateClass In RoommateList
            ' Check if the roommate's name matches the selected tab text
            If roommate.GetName() = selectedRoommateName Then
                ' Loop through the ExpenseList of the selected roommate
                For Each expense As ExpenseClass In roommate.getExpenseList()
                    totalExpense += Decimal.Parse(expense.getAmount())
                Next
            End If
        Next
        ESummaryLabel.Text = ($"Total: ${totalExpense}")
    End Sub
    Private Sub GenerateSharedExpenses()
        Dim selectedRoommateName As String = TabControl1.SelectedTab.Text
        Dim selectedRoommate As RoommateClass
        For Each roommate As RoommateClass In RoommateList
            If roommate.GetName() = selectedRoommateName Then
                selectedRoommate = roommate
                Exit For
            End If
        Next
        ESharedExpensesPanel.Controls.Clear() ' Clear existing controls in the panel
        ' Iterate through each expense in the selected roommate's expense list
        For Each selectedExpense As ExpenseClass In selectedRoommate.getExpenseList()
            If selectedExpense.getSplit() Then
                ' Iterate through each roommate in the list
                For Each otherRoommate As RoommateClass In getRoommateList()
                    ' Check if the roommate is not the selected roommate
                    If otherRoommate.GetName() <> selectedRoommateName Then
                        ' Iterate through each expense in the other roommate's expense list
                        For Each otherExpense As ExpenseClass In otherRoommate.getExpenseList()
                            ' Check if the expense names match
                            If otherExpense.getName() = selectedExpense.getName() Then
                                ' Create a label with roommate's name and expense amount
                                Dim label As New Label()
                                label.Width = 250
                                label.Text = $"{otherRoommate.GetName()}: {otherExpense.getName()} : {otherExpense.getAmount()}"
                                ESharedExpensesPanel.Controls.Add(label)
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub GeneratePersonalExpenses()
        Dim selectedRoommateName As String = TabControl1.SelectedTab.Text
        Dim selectedRoommate As RoommateClass
        For Each roommate As RoommateClass In RoommateList
            If roommate.GetName() = selectedRoommateName Then
                selectedRoommate = roommate
                Exit For
            End If
        Next
        EPersonalExpensesPanel.Controls.Clear() ' Clear existing controls in the panel
        If selectedRoommate IsNot Nothing Then
            ' Iterate through each expense in the selected roommate's expense list
            For Each selectedExpense As ExpenseClass In selectedRoommate.getExpenseList()
                Dim label As New Label()
                label.Width = 250
                label.Text = $"{selectedExpense.getName()} : {selectedExpense.getAmount()}"
                EPersonalExpensesPanel.Controls.Add(label)
            Next
        End If
    End Sub
    Private Sub EButton_Click(sender As Object, e As EventArgs) Handles EButton.Click, Button1.Click

        Dim expensesComponentForm As New Form()
        Dim expensesComponent As New ExpensesComponent()
        expensesComponentForm.Controls.Add(expensesComponent)
        expensesComponentForm.Text = "Expenses Form"
        expensesComponentForm.Size = New Size(500, 400)
        expensesComponentForm.ShowDialog()
    End Sub

#End Region

#Region "Reminder Pop up"
    Private inBobTab As Boolean
    Private inAliceTab As Boolean
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        'Reminder pop-up

        Dim rand As New Random
        Dim seconds As Integer
        seconds = rand.Next(30, 100)

        If TabControl1.SelectedTab Is BobTab Then
            inBobTab = True
            inAliceTab = False
        ElseIf TabControl1.SelectedTab Is AliceTab Then
            inBobTab = False
            inAliceTab = True

        End If
        Timer1.Interval = seconds * 1000
        Timer1.Start()
    End Sub

    'start timer

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If inBobTab Then
            Dim reminder1 As New ReminderView(1, "Alice", ChoreList)
            reminder1.Show()

        ElseIf inAliceTab Then
            Dim reminder1 As New ReminderView(0, "Bob", ChoreList)
            reminder1.Show()
        End If

    End Sub

#End Region
End Class
