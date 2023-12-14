Imports System.Text.RegularExpressions

Public Class ExpenseClass
    Private name As String
    Private amount As String
    Private split As Boolean
#Region "Initalizer and Formatting"
    Public Sub New(Ename As String, Samount As String, Ssplit As Boolean)
        name = Ename
        SetAmount(Samount)
        split = Ssplit
    End Sub
    Private Function ValidateMonetaryAmount(input As String) As Boolean
        ' Regular expression pattern for validating monetary amounts
        Dim pattern As String = "^\d+(\.\d{0,2})?$"

        ' Check if the input matches the pattern
        If Regex.IsMatch(input, pattern) Then
            ' If there is a decimal point and only one decimal place, add a "0"
            If input.Contains(".") AndAlso input.IndexOf(".") = input.Length - 2 Then
                input += "0"
                ' If there is no decimal point, add ".00" to the end
            Else
                input += ".00"
            End If
            ' The input is valid
            Return True
        Else
            ' The input is not valid
            Return False
        End If
    End Function
    Private Function FormatAmount(input As String) As String
        ' Ensure the amount has two decimal places
        If input.Contains(".") AndAlso input.IndexOf(".") = input.Length - 2 Then
            input += "0"
        End If

        ' If there is no decimal point, add ".00" to the end
        If Not input.Contains(".") Then
            input += ".00"
        End If

        Return input
    End Function
#End Region
#Region "Getters and Setters"
    Public Function getAmount()
        Return amount
    End Function
    Public Function getName()
        Return name
    End Function
    Public Function getSplit()
        Return split
    End Function
    Public Sub SetAmount(Samount As String)
        If ValidateMonetaryAmount(Samount) Then
            amount = FormatAmount(Samount)
        Else
            ' Handle the case where the amount is not valid (e.g., throw an exception, display an error message, etc.)
            Throw New ArgumentException("Invalid monetary amount.")
        End If
    End Sub
    Public Sub setName(Sname As String)
        name = Sname
    End Sub
    Public Sub setSplit(Ssplit As Boolean)
        split = Ssplit
    End Sub
#End Region
End Class
