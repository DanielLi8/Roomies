Public Class TodoCheckbox

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(name As String, recurring As String, effort As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.ChoreCheckbox.Text = name
        Me.RecurringLabel.Text = "Recurring: " & recurring

        Me.EffortLabel.Text = effort

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub RecurringLabel_Click(sender As Object, e As EventArgs) Handles RecurringLabel.VisibleChanged, RecurringLabel.Resize
        EffortIcon.Left = RecurringLabel.Right + 10
        EffortLabel.Left = RecurringLabel.Right + 30
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click

    End Sub

    Private Sub ChoreCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles ChoreCheckbox.CheckedChanged
        If ChoreCheckbox.Checked Then
            ChoreCheckbox.Font = New Font("Arial", 12.0F, FontStyle.Strikeout, GraphicsUnit.Point)
        Else
            ChoreCheckbox.Font = New Font("Arial", 12.0F, GraphicsUnit.Point)
        End If

    End Sub


End Class
