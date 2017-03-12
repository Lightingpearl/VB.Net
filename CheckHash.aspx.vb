
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Security
Imports System.Security.Cryptography
Imports System.Text
Imports Utilities

Partial Class CheckHash
    Inherits System.Web.UI.Page

    Dim utiliti As Utilities

    Public Function CreateRandomSalt() As String
        'the following is the string that will hold the salt charachters
        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=][}{<>"
        Dim salt As String = ""
        Dim rnd As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 100 'Length of the salt
            Dim x As Integer = rnd.Next(0, mix.Length - 1)
            salt &= (mix.Substring(x, 1))
        Next
        Return salt
    End Function

    Public Function Hash512(password As String) As String    '
        'Public Function Hash512(password As String, salt As String) As String
        '   Dim convertedToBytes As Byte() = Encoding.UTF8.GetBytes(password & salt)
        Dim convertedToBytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim hashType As HashAlgorithm = New SHA512Managed()
        Dim hashBytes As Byte() = hashType.ComputeHash(convertedToBytes)
        Dim hashedResult As String = Convert.ToBase64String(hashBytes)
        Return hashedResult
    End Function

    Protected Sub btnhash_Click(sender As Object, e As EventArgs) Handles btnhash.Click
        '   txtsalt.Text = CreateRandomSalt()
        '  txthashed.Text = (Hash512(txtpass.Text, CreateRandomSalt))
        txthashed.Text = (Hash512(txtpass.Text))
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtpass.Focus()

    End Sub

End Class
