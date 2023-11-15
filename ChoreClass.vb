Public Class ChoreClass
    Private choreName1 As String
    Private Recurring1 As String
    Private effortRating1 As Integer
    Private RoommateNum As Integer
    Public Property Name() As String
        Get
            Return choreName1
        End Get
        Set(ByVal value As String)
            choreName1 = value
        End Set
    End Property

    Public Property recurring() As String
        Get
            Return Recurring1
        End Get
        Set(ByVal value As String)
            Recurring1 = value
        End Set
    End Property

    Public Property Effort() As Integer
        Get
            Return effortRating1
        End Get
        Set(ByVal value As Integer)
            effortRating1 = value
        End Set
    End Property
    Public Property Roommate() As Integer
        Get
            Return RoommateNum
        End Get
        Set(ByVal value As Integer)
            RoommateNum = value
        End Set
    End Property








End Class
