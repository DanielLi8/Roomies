Public Class TodoCheckbox

    Private position1 As Integer
    'position keeps track of the index of todobox in todoboxList and chorelist

    Public Property position() As Integer
        Get
            Return position1
        End Get
        Set(ByVal value As Integer)
            position1 = value
        End Set
    End Property
#Region "Constructor"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Sub New(name As String, recurring As String, effort As Integer, position As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.ChoreCheckbox.Text = name
        Me.RecurringLabel.Text = "Recurring: " & recurring

        Me.EffortLabel.Text = effort
        Me.position = position
        ' Add any initialization after the InitializeComponent() call.

    End Sub
#End Region
    Private Sub RecurringLabel_Click(sender As Object, e As EventArgs) Handles RecurringLabel.VisibleChanged, RecurringLabel.Resize
        EffortIcon.Left = RecurringLabel.Right + 10
        EffortLabel.Left = RecurringLabel.Right + 30
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Dim chorelist = Roomies.getChoreList
        Dim choreEdit As New AddChore(chorelist(Me.position), Me.position)

        choreEdit.ShowDialog()

        Dim newChore = chorelist(Me.position)
        Me.ChoreCheckbox.Text = newChore.Name
        Me.RecurringLabel.Text = "Recurring: " & newChore.recurring
        Me.EffortLabel.Text = newChore.Effort
        Roomies.AddTodoboxToPanel()
        Roomies.AliceAddTodoboxToPanel()

    End Sub

    Private Sub ChoreCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles ChoreCheckbox.CheckedChanged
        If ChoreCheckbox.Checked Then
            ChoreCheckbox.Font = New Font("Arial", 12.0F, FontStyle.Strikeout, GraphicsUnit.Point)
            Dim copyCheckBox As New CheckBox
            copyCheckBox.Text = Me.ChoreCheckbox.Text
            copyCheckBox.Font = New Font("Arial", 12.0F, FontStyle.Strikeout, GraphicsUnit.Point)
            Me.ChoreCheckbox.Enabled = False
            Roomies.AddCompetedCheckBoxList(copyCheckBox)
            Roomies.UpdateCompletedPanelView()
            Roomies.AliceUpdateCompletedPanelView()
        Else
            ChoreCheckbox.Font = New Font("Arial", 12.0F, GraphicsUnit.Point)
            Dim copyCheckBox As New CheckBox

        End If

    End Sub


End Class
