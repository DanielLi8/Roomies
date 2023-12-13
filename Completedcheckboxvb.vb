Public Class Completedcheckboxvb
#Region "Constructors"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Sub New(name As String, DoneBy As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.CompletedCheckbox.Text = name
        Me.DoneByLabel.Text = "Done by: " & DoneBy


#End Region
    End Sub
End Class
