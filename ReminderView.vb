Imports System.Globalization

Public Class ReminderView
#Region "Constructor"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private RoommateName As String
    Private roommate As Integer
    Private chorelist As New List(Of ChoreClass)
    Public Sub New(Roommate As Integer, RoommateName As String, chorelist As List(Of ChoreClass))

        ' This call is required by the designer.
        InitializeComponent()
        'Adding Header
        Dim currentDate As DateTime = DateTime.Now
        Dim formattedDate As String = currentDate.ToString("ddd, MMM d", CultureInfo.InvariantCulture)
        Me.ReminderHeader.Text = formattedDate + ": " + RoommateName + "'s task(s) due"
        Me.chorelist = chorelist

        'Adding Remaning chores into reminder panel
        Dim VerticalSpacing As Integer = 0

        For Each chore In chorelist

            If chore.Roommate = Roommate Then
                Dim newLabel As New Label
                newLabel.Text = chore.Name
                newLabel.Font = New Font("Arial", 12)

                newLabel.Location = New Point(0, 30 * VerticalSpacing)
                ReminderPanel.Controls.Add(newLabel)
                VerticalSpacing += 1

            End If

        Next

    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

#End Region


End Class