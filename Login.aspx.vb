Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Security
Imports System.Security.Cryptography
Imports System.Text
Imports Utilities




Partial Class _Default
    Inherits System.Web.UI.Page


    Dim utilitie As New Utilities
  
    Public Function isEmpty() As Boolean
        Return String.IsNullOrEmpty(Me.txuser.Text) OrElse String.IsNullOrEmpty(Me.txtpass.Text)
    End Function

    
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
      
        If isEmpty() Then
            MsgBox("User or password is empty")

        ElseIf utilitie.Checklogin(Me.txuser.Text.ToLower, (utilitie.Hash512(Me.txtpass.Text.ToLower))) Then
            ' ElseIf utilitie.CheckLogin(Me.txuser.Text.ToLower, Me.txtpass.Text.ToLower) Then

            Session("UserName") = Me.txuser.Text
            Session("Password") = Me.txtpass.Text
            Response.Redirect("HomePage.aspx")
            MsgBox("Login Sugcess")


        Else
            MsgBox("Username or pasword is incorect")



        End If

      

    End Sub

    Protected Sub txuser_TextChanged(sender As Object, e As EventArgs) Handles txuser.TextChanged

    End Sub
End Class
