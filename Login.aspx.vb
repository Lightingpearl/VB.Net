Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Security.Cryptography

Public Class Login
    Inherits System.Web.UI.Page
    Private _connect As String = ConfigurationSettings.AppSettings("myconnectionstring")
    Private conn As SqlConnection
    Private da As SqlDataAdapter

    Private Function getDatatable(sqlQuery As String) As DataTable
        Dim dtable As New DataTable
        conn = New SqlConnection(_connect)
        da = New SqlDataAdapter(sqlQuery, conn)
        Try
            conn.Open()
            da.Fill(dtable)

        Catch ex As Exception
            'Hien thi thong bao loi tai day 
        Finally
            conn.Close()

        End Try
        Return dtable
    End Function

    Private Function Checklogin(user As String, pas As String)
        Dim sqlQuery As String = String.Format("Select * from Phanquyen where username='{0}' and password='{1}'", user, pas)
        Dim dTable As DataTable = getDatatable(sqlQuery)
        Return dTable.Rows.Count > 0

    End Function

    '    Private Function isEmpty() As Boolean
    '       Return String.IsNullOrEmpty(Me.txtusername.Text) OrElse String.IsNullOrEmpty(Me.txtpassword.Text)
    '  End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    
  
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Session("name") = txtname.Text
        Response.Redirect("Home.aspx")
        '/Server.Transfer("Home.aspx")

    End Sub
End Class