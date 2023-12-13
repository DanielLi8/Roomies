Imports System.Threading

Public Class AddChore

    Private isEdit As Boolean = False
    Private index1 As Integer = 0
    Private currentchore As New ChoreClass
    Private AliceCount As Integer = 0
    Private BobCount As Integer = 0
    Private CurrentUser As Integer
#Region "Constructors"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByRef BobCount As Integer, ByRef AliceCount As Integer, userNum As Integer)

        ' This call is required by the designer.
        InitializeComponent()


        Me.AliceCount = AliceCount
        Me.BobCount = BobCount
        Me.CurrentUser = userNum
    End Sub
    Public Sub New(chore As ChoreClass, index As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Edit(chore)
        index1 = index
        currentchore = chore
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Sub New(chore As ChoreClass, index As Integer, ByRef BobCount As Integer, ByRef AliceCount As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Edit(chore)
        index1 = index
        currentchore = chore
        Me.AliceCount = AliceCount
        Me.BobCount = BobCount
        ' Add any initialization after the InitializeComponent() call.

    End Sub
#End Region

#Region "Edit view"
    Public Sub Edit(chore As ChoreClass)
        ChoreInput.Text = chore.Name

        If chore.recurring = "Daily" Then
            RecurringDaily.Checked = True
        ElseIf chore.recurring = "Weekly" Then
            RecurringWeekly.Checked = True
        ElseIf chore.recurring = "Monthly" Then
            RecurringMonthly.Checked = True
        Else
            RecurringNone.Checked = True
        End If

        'set EffortRating
        If chore.Effort = 1 Then
            Effort1.Checked = True
        ElseIf chore.Effort = 2 Then
            Effort2.Checked = True
        ElseIf chore.Effort = 3 Then
            Effort3.Checked = True
        ElseIf chore.Effort = 4 Then
            Effort4.Checked = True
        ElseIf chore.Effort = 5 Then
            Effort5.Checked = True
        End If

        CreateButton.Text = "Update"
        isEdit = True


    End Sub
#End Region

#Region "Methods for the form"
    Private Sub AddChore_Load(sender As Object, e As EventArgs) Handles MyBase.Shown

        Dim rlist = Roomies.getRoommateList
        ' Add roommates to ComboBox
        For Each roommate In rlist
            Assignee.Items.Add(roommate.GetName)
        Next

        'if its the edit form
        If isEdit Then
            Dim roommateIndex As Integer = currentchore.Roommate
            Assignee.SelectedItem = rlist(roommateIndex).GetName
        End If

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
        If RadioButtonManual.Checked Then
            chore.Roommate = Assignee.SelectedIndex

        ElseIf RadioButtonRandom.Checked Then
            Dim rand As New Random()
            chore.Roommate = rand.Next(2) ' Generates either 0 or 1

        ElseIf RadioButtonOptimal.Checked Then
            If BobCount <= AliceCount Then
                chore.Roommate = 0
            Else
                chore.Roommate = 1
            End If
        End If
        If ExcludeRadioBtn.Checked Then
            If CurrentUser = 0 Then
                chore.Roommate = 1
            Else
                chore.Roommate = 0
            End If
        End If


        'Assign chore associated to roommate
        Dim rList = Roomies.getRoommateList()

        If isEdit Then

            Roomies.UpdateChoreList(chore, index1)
        Else
            Roomies.AddChoreList(chore)
        End If

        'close window
        Me.Close()

    End Sub


    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonManual.Click
        Assignee.Visible = True
    End Sub

    Private Sub RadioButtonRandom_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonRandom.Click, RadioButtonOptimal.Click
        Assignee.Visible = False
    End Sub





#End Region
End Class