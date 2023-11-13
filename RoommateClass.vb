Imports System.Runtime.CompilerServices

Public Class RoommateClass
    'Variables
    Private Name As String
    Private Address As String
    Private ExpenseList As List(Of String)
    Private ChoreList As List(Of String)

    'Constructors
    Public Sub New()
        Name = ""
        Address = ""
        ExpenseList = New List(Of String)
        ChoreList = New List(Of String)

    End Sub

    Public Sub New(name1 As String, address1 As String)
        Name = name1
        Address = address1
        ExpenseList = New List(Of String)
        ChoreList = New List(Of String)
    End Sub

#Region "Setter and getter for name"
    Public Sub setName(ByVal n As String)
        Name = n
    End Sub
    Public Function GetName() As String
        Return Name
    End Function
#End Region

#Region "Setter and getter for address"
    Public Sub setAddress(ByVal a As String)
        Address = a
    End Sub
    Public Function GetAddress() As String
        Return Address
    End Function
#End Region

#Region "Add, retrieve and remove from Chore list"
    Public Sub AddChore(ByVal chore As String)
        ChoreList.Add(chore)
    End Sub

    Public Function FindChore(chore) As String

        Dim index As Integer = ChoreList.IndexOf(chore)

        If index = -1 Then
            MessageBox.Show("Error, value not found")
            Return "error"
        Else
            Return ChoreList(index)
        End If

    End Function

    Public Sub RemoveChore(Chore As String)
        Dim index As Integer = ChoreList.IndexOf(Chore)

        If index = -1 Then
            MessageBox.Show("Error, value not found")
        Else
            ChoreList.RemoveAt(index)
        End If
    End Sub
#End Region

#Region "Add, retrieve and remove from expense list"

    Public Sub AddExepnse(ByVal expense As String)
        ExpenseList.Add(expense)
    End Sub

    Public Function FindExpense(expense) As String

        Dim index As Integer = ExpenseList.IndexOf(expense)

        If index = -1 Then
            MessageBox.Show("Error, value not found")
            Return "error"
        Else
            Return ExpenseList(index)
        End If

    End Function

    Public Sub RemoveExpense(Expense As String)
        Dim index As Integer = ExpenseList.IndexOf(Expense)

        If index = -1 Then
            MessageBox.Show("Error, value not found")
        Else
            ExpenseList.RemoveAt(index)
        End If
    End Sub

#End Region
End Class


