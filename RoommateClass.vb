Imports System.Runtime.CompilerServices

Public Class RoommateClass
    'Variables
    Private Name As String
    Private Address As String
    Private ExpenseList As List(Of ExpenseClass)
    'expense should be its own class with cost
    Private ChoreList As List(Of ChoreClass)
    'can convert into class for chorelist since it has a property for recurring, effort rating
    'Constructors
    Public Sub New()
        Name = ""
        Address = ""
        ExpenseList = New List(Of ExpenseClass)
        ChoreList = New List(Of ChoreClass)

    End Sub

    Public Sub New(name1 As String, address1 As String)
        Name = name1
        Address = address1
        ExpenseList = New List(Of ExpenseClass)
        ChoreList = New List(Of ChoreClass)
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
    Public Sub AddChore(ByVal chore As ChoreClass)
        ChoreList.Add(chore)
    End Sub

    Public Sub UpdateChore(ByVal chore As ChoreClass, index As Integer)
        ChoreList(index) = chore
    End Sub

    Public Function getChoreIndex(chore) As Integer
        Return ChoreList.IndexOf(chore)

    End Function
    Public Function getChore(chore) As ChoreClass

        Dim index As Integer = ChoreList.IndexOf(chore)

        If index = -1 Then
            MessageBox.Show("Error, value not found")
            Return New ChoreClass
        Else
            Return ChoreList(index)
        End If

    End Function

    Public Sub RemoveChore(Chore As ChoreClass)
        Dim index As Integer = ChoreList.IndexOf(Chore)

        If index = -1 Then
            MessageBox.Show("Error, value not found")
        Else
            ChoreList.RemoveAt(index)
        End If
    End Sub
#End Region

#Region "Add, retrieve, edit, and remove from expense list"

    ' Add an expense to the list
    Public Sub AddExpense(ByVal expense As ExpenseClass)
        ExpenseList.Add(expense)
    End Sub

    ' Retrieve an expense by name
    Public Function GetExpenseByName(name As String) As ExpenseClass
        Dim matchingExpense As ExpenseClass = ExpenseList.Find(Function(expense) expense.getName() = name)

        If matchingExpense IsNot Nothing Then
            Return matchingExpense
        Else
            MessageBox.Show("Error: Expense not found.")
            Return New ExpenseClass("", "0.00")
        End If
    End Function

    ' Edit the name and amount of an expense
    Public Sub EditExpenseByName(oldName As String, newName As String, newAmount As String)
        Dim matchingExpense As ExpenseClass = ExpenseList.Find(Function(expense) expense.getName() = oldName)

        If matchingExpense IsNot Nothing Then
            matchingExpense.setName(newName)
            matchingExpense.SetAmount(newAmount)
        Else
            MessageBox.Show("Error: Expense not found.")
        End If
    End Sub

    ' Remove an expense by name
    Public Sub RemoveExpenseByName(name As String)
        Dim matchingExpense As ExpenseClass = ExpenseList.Find(Function(expense) expense.getName() = name)

        If matchingExpense IsNot Nothing Then
            ExpenseList.Remove(matchingExpense)
        Else
            MessageBox.Show("Error: Expense not found.")
        End If
    End Sub

#End Region
End Class


