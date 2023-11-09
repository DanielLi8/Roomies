Public Class HouseholdDetails

    Private myRoomies As Roomies

    Public Sub New(myRoomies As Roomies)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.myRoomies = myRoomies

        ' Add any initialization after the InitializeComponent() call.
        Me.Show()

        ' Put code here to handle the delay specified by the seconds parameter

    End Sub


    Dim roommateControls As New List(Of RoommateAddLayout) 'list to keep track of dynamic generation
    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click, RadioButton4.Click
        For Each control In roommateControls
            Me.Controls.Remove(control)
        Next
        roommateControls.Clear()
        Dim roommatesnum As Integer
        Dim total As Integer = 4
        If RadioButton1.Checked Then
            RoommatesNum = 1
        ElseIf RadioButton2.Checked Then
            RoommatesNum = 2

        ElseIf RadioButton3.Checked Then
            RoommatesNum = 3

        ElseIf RadioButton4.Checked Then
            RoommatesNum = 4

        End If

        Dim number As Integer = 1
        Dim VerticalSpacing As Integer = 1

        For i As Integer = 0 To roommatesnum - 1
            Dim addRoommate As New RoommateAddLayout
            addRoommate.nameLabel.Text = "Roommate " & number
            addRoommate.Location = New Point(85, 140 * VerticalSpacing)

            Controls.Add(addRoommate)
            roommateControls.Insert(i, addRoommate)
            number += 1
            VerticalSpacing += 1
        Next
        CreateBtn.Location = New Point(90, 140 * VerticalSpacing)
        CancelBtn.Location = New Point(265, 140 * VerticalSpacing)

    End Sub


    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        myRoomies.AddHouseholdBtn.Enabled = True
        Me.Close()
    End Sub
End Class