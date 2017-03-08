Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Security.Cryptography





Public Class frmLogin
    Public Sub xulyhienthi(str As String)
        MessageBox.Show("this: " + str)
    End Sub


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
            MessageBox.Show(ex.Message, "Error")
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

    Private Function isEmpty() As Boolean
        Return String.IsNullOrEmpty(Me.txtusername.Text) OrElse String.IsNullOrEmpty(Me.txtpassword.Text)
    End Function


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusername.Focus()

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        'Application.Exit()
        Me.Close()

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try
            If isEmpty() Then
                MessageBox.Show("Username or Password not blank!!", "No entry",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If Checklogin(Me.txtusername.Text.ToLower, Me.txtpassword.Text.ToLower) Then
                        MessageBox.Show("Login Successfully ")
                        Dim home As New frmHome
                        Me.Hide()
                        AddHandler home.xylyhienthi, AddressOf xulyhienthi
                        home.Show()
                Else
                    MessageBox.Show("Username or password is incorrect")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Something wrong !!!", "No entry", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtusername.Text = ""
        txtpassword.Text = ""
        txtusername.Focus()


    End Sub

    Private Sub txtusername_Enter(sender As Object, e As EventArgs) Handles txtusername.Enter
        txtpassword.Focus()

    End Sub

    Private Sub txtpassword_Enter(sender As Object, e As EventArgs) Handles txtpassword.Enter
        btnlogin_Click(sender, e)


    End Sub

    Private Sub txtusername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusername.KeyDown
        If e.KeyValue = Keys.Enter Then

            txtpassword.Focus()


        End If

    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnlogin_Click(sender, e)
        End If
    End Sub
End Class
