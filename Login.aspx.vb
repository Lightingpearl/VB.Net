Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Security
Imports System.Security.Cryptography
Imports System.Text
Imports System.Configuration
Imports Utilities




Partial Class _Default
    Inherits System.Web.UI.Page

    Dim utilitie As New Utilities

    Dim _ConnectionString As String = ConfigurationManager.ConnectionStrings("QLSVConnect").ConnectionString

    Public conn As New SqlConnection
    Public da As SqlDataAdapter

    Public Function getDataTable(sqlQuery As String) As DataTable
        Dim dTable As New DataTable
        conn = New SqlConnection(_ConnectionString)
        da = New SqlDataAdapter(sqlQuery, conn)
        Try
            ' Dim str As String = "Data Source=Y;Initial Catalog=QLSV;Integrated Security=True"
            '  conn.ConnectionString = str
            conn.Open()
            da.Fill(dTable)
        Catch ex As Exception

            MsgBox("you have an error when try to read database")

        Finally
            conn.Close()
        End Try
        Return dTable
    End Function

    Public Function Checklogin(user As String, pas As String) As Boolean
        Dim sqlQuery As String = String.Format("Select * from Phanquyen where username='{0}' and password='{1}'", user, pas)
        Dim dTable As DataTable = getDataTable(sqlQuery)
        Return dTable.Rows.Count > 0

    End Function




  
    Public Function isEmpty() As Boolean
        Return String.IsNullOrEmpty(Me.txuser.Text) OrElse String.IsNullOrEmpty(Me.txtpass.Text)
    End Function

    
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        txuser.Focus()
    End Sub

    Protected Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
      
        If isEmpty() Then
            MsgBox("User or password is empty")

        ElseIf Checklogin(Me.txuser.Text.ToLower, (utilitie.Hash512(Me.txtpass.Text.ToLower))) Then
            ' ElseIf utilitie.CheckLogin(Me.txuser.Text.ToLower, Me.txtpass.Text.ToLower) Then

            Session("UserName") = Me.txuser.Text
            Session("Password") = Me.txtpass.Text
            MsgBox("Login Sugcess")
            Response.Redirect("HomePage.aspx")
            

        Else
            MsgBox("Username or pasword is incorect")
            txuser.Text = String.Empty
            txtpass.Text = String.Empty
        End If

    End Sub
End Class
