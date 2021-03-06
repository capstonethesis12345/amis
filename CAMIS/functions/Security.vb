﻿Imports System.Security.Cryptography
Imports System.Text
Imports MetroFramework.Controls

Module Security
    Private ErrorProvider1 As Object

    Function getMD5(ByVal strToHash As String) As String

        Dim md5Obj As New MD5CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function

    Function caseletters(ByVal str As TextBox) As TextBox
        Dim theText As String = str.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = str.SelectionStart
        Dim Change As Integer
        Dim charactersAllowed As String = " abcdefghijklmnopqrstuvwxyz"
        For x As Integer = 0 To str.Text.Length - 1
            Letter = str.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter.ToLower) = False Then
                theText = theText.Replace(Letter, String.Empty)

                Change = 1
            End If
        Next

        str.Text = theText
        str.Select(SelectionIndex - Change, 0)
        Return str
    End Function
    Function metrocaseletters(ByVal str As MetroTextBox) As MetroTextBox
        Dim theText As String = str.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = str.SelectionStart
        Dim Change As Integer
        Dim charactersAllowed As String = " abcdefghijklmnopqrstuvwxyz"
        For x As Integer = 0 To str.Text.Length - 1
            Letter = str.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter.ToLower) = False Then
                theText = theText.Replace(Letter, String.Empty)

                Change = 1
            End If
        Next
        str.Text = theText
        str.Select(SelectionIndex - Change, 0)
        Return str
    End Function

    Function casenumbers(ByVal str As TextBox) As TextBox
        Dim theText As String = str.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = str.SelectionStart
        Dim Change As Integer
        Dim charactersAllowed As String = " 1234567890."
        For x As Integer = 0 To str.Text.Length - 1
            Letter = str.Text.Substring(x, 1)

            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)

                Change = 1
            End If
        Next

        str.Text = theText
        str.Select(SelectionIndex - Change, 0)
        Return str
    End Function

    Function metrocasenumbers(ByVal str As MetroTextBox) As MetroTextBox
        Dim theText As String = str.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = str.SelectionStart
        Dim Change As Integer
        Dim charactersAllowed As String = " 1234567890."
        For x As Integer = 0 To str.Text.Length - 1
            Letter = str.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        str.Text = theText
        str.Select(SelectionIndex - Change, 0)
        Return str
    End Function


    Function ifempty(ByVal str As MetroTextBox) As Boolean
        Dim theText As String = str.Text
        If theText = "" Then
            hasError = True
            str.WaterMarkColor = Color.Red
            str.WaterMark = "!"
        Else
            hasError = False
        End If
        Return hasError
    End Function
    Function ifcomboempty(ByVal str As ComboBox) As Boolean
        Dim theText As String = str.Text
        If theText = "" Then
            hasError = True
            str.BackColor = Color.Red
        Else
            hasError = False
        End If
        Return hasError
    End Function
End Module